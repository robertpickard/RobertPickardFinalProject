using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISfTE.DataAccess.Data.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ISfTE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //Filter based on what Role the Admin currently wants to view. 
            return Json(new { data = _unitOfWork.ApplicationUser.GetAll() });
        }

        [HttpPost]
        public IActionResult LockUnlock([FromBody]string id)
        {
            var objFromDatabase = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == id);
            if (objFromDatabase == null)
            {
                return Json(new { success = false, message = "Error while Locking/Unlocking" });
            }

            if (objFromDatabase.LockoutEnd != null && objFromDatabase.LockoutEnd > DateTime.Now)
            {
                //User is currently locked out so unlock them
                objFromDatabase.LockoutEnd = DateTime.Now;
            }
            else
            {
                //lock user
                objFromDatabase.LockoutEnd = DateTime.Now.AddYears(100);
            }
            _unitOfWork.Save();

            return Json(new { success = true, message = "Lock/Unlock Successful" });

        }
    }
}