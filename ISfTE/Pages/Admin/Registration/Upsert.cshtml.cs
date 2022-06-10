using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ISfTE.DataAccess;
using ISfTE.Models;
using ISfTE.Models.ViewModels;
using ISfTE.DataAccess.Data.Repository.IRepository;
using System.Security.Claims;
using ISfTE.Utility;
using Microsoft.AspNetCore.Hosting;

namespace ISfTE.Pages.Admin.Registration
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
        public RegistrationVM RegistrationObj { get; set; }

        public IActionResult OnGet(int? id)
        {
            RegistrationObj = new RegistrationVM()
            {
                CountryList = _unitOfWork.Country.GetCountryListForDropDown(),

                Registration = new Models.Registration(),

                Guest = new Models.Guest(),

                Countries = _unitOfWork.Country.GetCountries(),

                SelectedCountry = 1
            };

            //USING ATTENDEEE ID for users to edit their own registration
            //var claimsIdentity = (ClaimsIdentity)User.Identity;
            //var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            //if (claim != null) //Edit from a user
            //{
            //    RegistrationObj.Registration = _unitOfWork.Registration.GetFirstOrDefault(u => u.AttendeeId == claim.Value);

            //    //If the user has not created a registration yet.
            //    if (RegistrationObj.Registration == null)
            //    {
            //        RegistrationObj.Registration = new Models.Registration
            //        {
            //            Id = 0,
            //            AttendeeId = claim.Value,
            //            Organization = "",
            //            StreetLine1 = "",
            //            StreetLine2 = "",
            //            TerritoryState = "",
            //            PostalCode = "",
            //            CountryId = 0,
            //            Fax = "",
            //            TotalCost = 0,
            //            PreferredName = "",
            //            ArrivalTransport = "",
            //            ArrivalDateTime = default(DateTime),
            //            DepartTransport = "",
            //            DepartDateTime = default(DateTime),
            //            DietDisabilityNeeds = "",
            //            Hotel = "",
            //            HotelInDate = default(DateTime),
            //            HotelOutDate = default(DateTime)
            //        };
            //    }
            //}
            //else
            //{
            //    return NotFound();
            //}


            //USING REGISTRATION ID for admins to edit a registration without changing the attendee Id
            if (id != null) //edit
            {
                RegistrationObj.Registration = _unitOfWork.Registration.GetFirstOrDefault(u => u.Id == id);
                RegistrationObj.Guest = _unitOfWork.Guest.GetFirstOrDefault(g => g.RegistrationId == RegistrationObj.Registration.Id);
                if (RegistrationObj == null)
                {
                    return NotFound();
                }
            }
            
            //RegistrationObj.CountryList = _unitOfWork.Country.GetCountryListForDropDown();

            if (RegistrationObj.CountryList == null || RegistrationObj.Registration == null)
            {
                return NotFound();
            }

            return Page();
        }

            
        

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                bool SelectedCountry = false;
                //RegistrationObj.CountryList = _unitOfWork.Country.GetCountryListForDropDown();
                foreach (var modelstateKey in ModelState.Keys)
                {
                    var value = ModelState[modelstateKey];
                    var rawValue = value.ToString();
                    if (value.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid && modelstateKey.Contains("SelectedCountry"))
                    {
                        SelectedCountry = true;
                    }
                    else if (value.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
                    {
                        return Page();
                    }
                }

                if (SelectedCountry != true)
                {
                    return Page();
                }

            }

            //Update the Country with what the user chose
            RegistrationObj.Registration.Country = _unitOfWork.Country.GetFirstOrDefault(u => u.Id == RegistrationObj.Registration.CountryId);

            if (RegistrationObj.Registration.Country.CountryTypeId == 1)
            {
                RegistrationObj.Registration.TotalCost = SD.DevelopedCountry;
            }
            if (RegistrationObj.Registration.Country.CountryTypeId == 2)
            {
                RegistrationObj.Registration.TotalCost = SD.UndevelopedCountry;
            }

            if (!(RegistrationObj.Guest.Email == null && RegistrationObj.Guest.FirstName == null
                && RegistrationObj.Guest.LastName == null))
            {
                RegistrationObj.Registration.TotalCost += SD.GuestPrice;
            }

            if (RegistrationObj.Registration.Id == 0) //new registration, should not happen on admin page
            {
                return Page();
            }

            else //edit
            {
                //var objFromDb = _unitOfWork.Registration.Get(RegistrationObj.Registration.Id);

                _unitOfWork.Registration.Update(RegistrationObj.Registration);
                _unitOfWork.Guest.Update(RegistrationObj.Guest);
            }

            _unitOfWork.Save();
            return RedirectToPage("/Admin/Registration/Index");
        }

    }
}
