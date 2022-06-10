using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISfTE.DataAccess.Data.Repository.IRepository;
using ISfTE.Models.ViewModels;
using ISfTE.Utility;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ISfTE.Pages.AbstractReview
{
    public class UpsertModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostingEnvironment;
        

        public UpsertModel(IUnitOfWork unitOfWork, IWebHostEnvironment hostingEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostingEnvironment = hostingEnvironment;
            
        }

        [BindProperty]
        public AbstractReviewVM abstractObj { get; set; }

        public void OnGet(int id)
        {
            //populate the VM
            abstractObj = new AbstractReviewVM
            {
                Abstract = _unitOfWork.Abstract.GetFirstOrDefault(a => a.Id == id, "ApplicationUser"),
                AbstractRatings = _unitOfWork.AbstractRating.GetAll(r => r.AbstractId == id, null, "ApplicationUser")
            };
        }

        public IActionResult OnPostApprove()
        {
            //if approved, update the abstract and the current user status to reflect the change
            var objFromDb = _unitOfWork.Abstract.GetFirstOrDefault(a => a.Id == abstractObj.Abstract.Id, "ApplicationUser");
            abstractObj.Abstract = objFromDb;

            abstractObj.Abstract.Approved = true;
            abstractObj.Abstract.ReviewDate = DateTime.Now;

            _unitOfWork.Abstract.Update(abstractObj.Abstract);
            if (abstractObj.Abstract.ApplicationUser.Status != SD.Admin && abstractObj.Abstract.ApplicationUser.Status != SD.Rater)
            {
                
                _unitOfWork.ApplicationUser.UpdateRole(abstractObj.Abstract.AuthorId, SD.AbstractApproved);

            }
            _unitOfWork.Save();

            return RedirectToPage("Index");
        }

        public IActionResult OnPostReject()
        {
            //if rejectedc, update the abstract and the current user status to reflect the change
            var objFromDb = _unitOfWork.Abstract.GetFirstOrDefault(a => a.Id == abstractObj.Abstract.Id, "ApplicationUser");
            abstractObj.Abstract = objFromDb;

            abstractObj.Abstract.Approved = false;
            abstractObj.Abstract.ReviewDate = DateTime.Now;

            _unitOfWork.Abstract.Update(abstractObj.Abstract);
            if(abstractObj.Abstract.ApplicationUser.Status != SD.Admin && abstractObj.Abstract.ApplicationUser.Status != SD.Rater)
            {
                
                _unitOfWork.ApplicationUser.UpdateRole(abstractObj.Abstract.AuthorId, SD.AbstractRejected);

            }
            _unitOfWork.Save();

            return RedirectToPage("Index");
        }
    }
}