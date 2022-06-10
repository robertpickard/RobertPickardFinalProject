using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ISfTE.DataAccess.Data.Repository.IRepository;
using ISfTE.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ISfTE.Pages.AbstractRating
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
        public AbstractRatingVM AbstractRatingObj { get; set; }

        public IActionResult OnGet(int? ratingId, int? abstractId)
        {
            //check to see if the abstract has been rated before by the user
            AbstractRatingObj = new AbstractRatingVM();
            if(ratingId != null)
            {
                AbstractRatingObj.AbstractRating = _unitOfWork.AbstractRating.GetFirstOrDefault(a => a.Id == ratingId);
            }
            else
            {
                //if not, initialize the rating VM
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                AbstractRatingObj.AbstractRating = new Models.AbstractRating
                {
                    Id = 0,
                    AbstractId = (int)abstractId,
                    RaterId = claim.Value,
                    ConferenceFit = 3,
                    Contribution = 3,
                    Mechanics = 3
                };
            }
            AbstractRatingObj.Abstract = _unitOfWork.Abstract.GetFirstOrDefault(a => a.Id == abstractId, "ApplicationUser");

            if (AbstractRatingObj.AbstractRating == null || AbstractRatingObj.Abstract == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //save the rating to the db
            AbstractRatingObj.AbstractRating.RatingDate = DateTime.Now;
            if (AbstractRatingObj.AbstractRating.Id == 0)
            {
                _unitOfWork.AbstractRating.Add(AbstractRatingObj.AbstractRating);
            }
            else
            {
                _unitOfWork.AbstractRating.Update(AbstractRatingObj.AbstractRating);
            }

            _unitOfWork.Save();

            return RedirectToPage("./Index");
        }
    }
}