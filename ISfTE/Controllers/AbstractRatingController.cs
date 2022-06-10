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
    public class AbstractRatingController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AbstractRatingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //Make sure to Filter Based on Current Rater
            
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if(claim != null)
            {
                var abstracts = _unitOfWork.Abstract.GetAll(a => a.ReviewDate == null && a.AuthorId != claim.Value, null, "ApplicationUser");
                return Json(new
                {
                    data = from a in abstracts
                           select new
                           {
                               Id = a.Id,
                               Title = a.Title,
                               Author = a.ApplicationUser.FullName,
                               DocPath = a.DocPath,
                               RateCount = _unitOfWork.AbstractRating.RatingCount(a.Id),
                               Rating = _unitOfWork.AbstractRating.GetFirstOrDefault(r => r.AbstractId == a.Id && r.RaterId == claim.Value)
                           }
                });
            }

            return NotFound(); ;
        }
    }
}