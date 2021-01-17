namespace JobManagement.Factories
{
    using System.Linq;
    using System.Threading.Tasks;
    using Interfaces;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Models.Account;
    using Services;

    public class RegistrationUserViewModelFactory : IRegistrationUserViewModelFactory
    {
        private readonly IGenderService _genderService;
        private readonly ICountryService _countryService;
        private readonly ITownService _townService;

        public RegistrationUserViewModelFactory(IGenderService genderService, ICountryService countryService, ITownService townService)
        {
            _genderService = genderService;
            _countryService = countryService;
            _townService = townService;
        }

        public async Task<RegistrationUserViewModel> CreateAsync()
        {
            var model = new RegistrationUserViewModel();
            var genders = await _genderService.GetPageAsync(0, int.MaxValue);
            var gendersItems = genders.OrderBy(x => x.Position).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
            model.Genders = new SelectList(gendersItems, "Value", "Text");

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
