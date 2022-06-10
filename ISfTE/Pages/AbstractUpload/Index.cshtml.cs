using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ISfTE.DataAccess.Data.Repository.IRepository;
using ISfTE.Models;
using ISfTE.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ISfTE.Pages.AbstractUpload
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public IndexModel(
            IUnitOfWork unitOfWork,
            IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _unitOfWork = unitOfWork;
        }

        [BindProperty]
        public Abstract Abstract { get; set; }

        public async Task OnGetAsync()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            Abstract = _unitOfWork.Abstract.GetFirstOrDefault(a => a.AuthorId == claim.Value);

            if (Abstract == null)
            {
                Abstract = new Abstract();
                Abstract.Id = 0;
                Abstract.AuthorId = claim.Value;
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {

            //Find path to wwwroot
            string webRootPath = _hostingEnvironment.WebRootPath;
            //Grab the file(s) from the form
            var files = HttpContext.Request.Form.Files;

            if (ModelState.IsValid)
            {
                //verify file upload
                if (files.Count == 0)
                {
                    return Page();
                }
                //rename the file user submits
                string fileName = Guid.NewGuid().ToString();
                //upload to path
                var uploads = Path.Combine(webRootPath, @"documents\abstracts");
                //preserve our extension
                var extension = Path.GetExtension(files[0].FileName);

                if(extension != ".pdf" && extension != ".doc" && extension != ".docx")
                {
                    return Page();
                }
                if(((files[0].Length / 1024)/ 1024) > SD.MaxUploadMB)
                {
                    return Page();
                }
                using (var filestream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(filestream);
                }

                Abstract.DocPath = @"\documents\abstracts\" + fileName + extension;
                Abstract.Approved = false;
                _unitOfWork.Abstract.Add(Abstract);
                if (!User.IsInRole(SD.AdminRole) && !User.IsInRole(SD.RaterRole))
                {
                    _unitOfWork.ApplicationUser.UpdateRole(Abstract.AuthorId, SD.AbstractSubmitted);

                }

                _unitOfWork.Save();
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}