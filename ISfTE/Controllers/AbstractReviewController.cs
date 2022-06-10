using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ISfTE.DataAccess.Data.Repository.IRepository;
using ISfTE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISfTE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbstractReviewController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AbstractReviewController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (claim != null)
            {
                var abstracts = _unitOfWork.Abstract.GetAll(a => a.AuthorId != claim.Value, null, "ApplicationUser");

                return Json(new
                {
                    data = from a in abstracts
                           select new
                           {
                               Id = a.Id,
                               Title = a.Title,
                               Author = a.ApplicationUser.FullName,
                               DocPath = a.DocPath,
                               Approved = a.Approved,
                               Date = a.ReviewDate,
                               RateCount = _unitOfWork.AbstractRating.RatingCount(a.Id),
                               Rating = _unitOfWork.AbstractRating.AvgRating(a.Id)
                           }
                });
            }

            return NotFound();
        }
    }
}