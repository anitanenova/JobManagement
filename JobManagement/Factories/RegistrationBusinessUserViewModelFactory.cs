namespace JobManagement.Factories
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Interfaces;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Models.Account;
    using Models.BusinessUser;
    using Models.Models;
    using Models.User;
    using Services;

    public class RegistrationBusinessUserViewModelFactory : IRegistrationBusinessUserViewModelFactory
    {
        private readonly IBusinessSectorsService _businessSectorsService;

        private readonly ICountryService _countryService;
        private readonly ITownService _townService;

        public RegistrationBusinessUserViewModelFactory(IBusinessSectorsService businessSectorsService, ICountryService countryService, ITownService townService)
        {
            _businessSectorsService = businessSectorsService;

            _countryService = countryService;
            _townService = townService;
        }

        public async Task<RegistrationBusinessUserViewModel> CreateAsync()
        {
            var model = new RegistrationBusinessUserViewModel();
            var businessSectors = await _businessSectorsService.GetPageAsync(0, int.MaxValue);
            var businessSectorItems = businessSectors.OrderBy(x => x.Position).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
            model.BusinessSectors = new SelectList(businessSectorItems, "Value", "Text");

            var countries = await _countryService.GetPageAsync(0, int.MaxValue);
            var countriesItems = countries.OrderBy(x => x.Position).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
            model.Countries = new SelectList(countriesItems, "Value", "Text");

            var towns = await _townService.GetPageAsync(0, int.MaxValue);
            var townsItems = towns.OrderBy(x => x.Position).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
            model.Towns = new SelectList(townsItems, "Value", "Text");

            return model;
        }

    }
}
