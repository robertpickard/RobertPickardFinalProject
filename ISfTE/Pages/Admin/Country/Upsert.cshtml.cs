using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISfTE.DataAccess.Data.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ISfTE.Models.ViewModels;

namespace ISfTE.Pages.Admin.Country
{
    public class UpsertModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public UpsertModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [BindProperty]
        public CountryVM CountryObj { get; set; }
        public IActionResult OnGet(int? id)
        {

            CountryObj = new CountryVM
            {
                CountryTypeList =
                _unitOfWork.CountryType.GetCountryTypeListForDropDown(),

                Country = new Models.Country()
            };

            if (id != null) //edit
            {
                CountryObj.Country = _unitOfWork.Country.GetFirstOrDefault(u => u.Id == id);
                if (CountryObj == null)
                {
                    return NotFound();
                }
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (CountryObj.Country.Id == 0) //new country
            {
                _unitOfWork.Country.Add(CountryObj.Country);
            }

            else //edit
            {
                _unitOfWork.Country.Update(CountryObj.Country);
            }

            _unitOfWork.Save();
            return RedirectToPage("./Index");
        }
    }
}