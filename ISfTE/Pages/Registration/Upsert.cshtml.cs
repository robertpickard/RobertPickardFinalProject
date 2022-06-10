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

namespace ISfTE.Pages.Registration
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

        public ApplicationUser user { get; set; }

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
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (claim != null) //Edit from a user
            {
                user = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == claim.Value);
                RegistrationObj.Registration = _unitOfWork.Registration.GetFirstOrDefault(u => u.AttendeeId == claim.Value);
                if (RegistrationObj.Registration != null)
                {
                    RegistrationObj.Guest = _unitOfWork.Guest.GetFirstOrDefault(g => g.RegistrationId == RegistrationObj.Registration.Id);
                }

                RegistrationObj.SelectedCountry = 1;
                //If the user has not created a registration yet.
                if (RegistrationObj.Registration == null)
                {
                    RegistrationObj.Registration = new Models.Registration
                    {
                        Id = 0,
                        AttendeeId = claim.Value,
                        StreetLine1 = "",
                        StreetLine2 = "",
                        TerritoryState = "",
                        PostalCode = "",
                        CountryId = 0,
                        Fax = "",
                        TotalCost = 0,
                        ArrivalTransport = "",
                        DepartTransport = "",
                        DietDisabilityNeeds = "",
                        Hotel = "",
                    };

                    RegistrationObj.Guest = new Models.Guest
                    {
                        Id = 0,
                        RegistrationId = RegistrationObj.Registration.Id,
                        Email = "",
                        FirstName = "",
                        LastName = "",
                        Relationship = ""
                    };
                }
            }
            else
            {
                return NotFound();
            }


            //USING REGISTRATION ID
            //if (id != null) //edit
            //{
            //    RegistrationObj.Registration = _unitOfWork.Registration.GetFirstOrDefault(u => u.Id == id);
            //    if (RegistrationObj == null)
            //    {
            //        return NotFound();
            //    }

            //    //Only assign AttendeeId if the user is an attendee
            //    //This is to prevent Admin user being assigned as the attendee
            //    //if(User.IsInRole(SD.AttendeeRole)){
            //    //RegistrationObj.Registration.AttendeeId = claim.Value;
            //    //}
            //}
            //else
            //{
            //    RegistrationObj.Registration = new Models.Registration
            //    {
            //        Id = 0,
            //        AttendeeId = claim.Value,
            //        Organization = "",
            //        StreetLine1 = "",
            //        StreetLine2 = "",
            //        TerritoryState = "",
            //        PostalCode = "",
            //        CountryId = 0,
            //        Fax = "",
            //        TotalCost = 0,
            //        PreferredName = "",
            //        ArrivalTransport = "",
            //        ArrivalDateTime = default(DateTime),
            //        DepartTransport = "",
            //        DepartDateTime = default(DateTime),
            //        DietDisabilityNeeds = "",
            //        Hotel = "",
            //        HotelInDate = default(DateTime),
            //        HotelOutDate = default(DateTime)
            //    };
            //}
            //RegistrationObj.CountryList = _unitOfWork.Country.GetCountryListForDropDown();

            if(RegistrationObj.CountryList == null || RegistrationObj.Registration == null)
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

            //Set Cost value depending on developed vs undeveloped country
            if (RegistrationObj.Registration.Country.CountryTypeId == 1)
            {
                RegistrationObj.Registration.TotalCost = SD.DevelopedCountry;
            }
            if (RegistrationObj.Registration.Country.CountryTypeId == 2)
            {
                RegistrationObj.Registration.TotalCost = SD.UndevelopedCountry;
            }

            //Add guest pricing if a guest is included
            if (!(RegistrationObj.Guest.Email == null && RegistrationObj.Guest.FirstName == null
                && RegistrationObj.Guest.LastName == null))
            {
                RegistrationObj.Registration.TotalCost += SD.GuestPrice;
            }

            if (RegistrationObj.Registration.Id == 0) //new registration
            {
                //add registration to DB
                _unitOfWork.Registration.Add(RegistrationObj.Registration);
                _unitOfWork.Save();

                //get the registration object from the db with its new auto-assigned ID
                var claimsIdentity = (ClaimsIdentity)User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                RegistrationObj.Registration = _unitOfWork.Registration.GetFirstOrDefault(u => u.AttendeeId == claim.Value);

                //use the new registration id with the guest
                RegistrationObj.Guest.RegistrationId = RegistrationObj.Registration.Id;

                _unitOfWork.Guest.Add(RegistrationObj.Guest);
            }

            else //edit
            {
                //var objFromDb = _unitOfWork.Registration.Get(RegistrationObj.Registration.Id);

                _unitOfWork.Registration.Update(RegistrationObj.Registration);
                _unitOfWork.Guest.Update(RegistrationObj.Guest);
            }
            if(!User.IsInRole(SD.AdminRole) && !User.IsInRole(SD.RaterRole))
            {
                _unitOfWork.ApplicationUser.UpdateRole(RegistrationObj.Registration.AttendeeId, SD.Registered);
            }
           
            _unitOfWork.Save();
            return RedirectToPage("/Index");
        }
    }
}
