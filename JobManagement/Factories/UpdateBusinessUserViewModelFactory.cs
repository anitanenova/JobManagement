namespace JobManagement.Factories
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Helper;
    using Interfaces;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using Models.BusinessUser;
    using Models.Models;
    using Models.User;
    using Services;

    public class UpdateBusinessUserViewModelFactory : IUpdateBusinessUserViewModelFactory
    {
        private readonly IBusinessUserService _businessUserService;
        private readonly IBusinessSectorsService _businessSectorsService;
        private readonly ICountryService _countryService;
        private readonly ITownService _townService;

        public UpdateBusinessUserViewModelFactory(IBusinessUserService businessUserService, IBusinessSectorsService businessSectorsService, ICountryService countryService, ITownService townService)
        {
            _businessUserService = businessUserService;
            _businessSectorsService = businessSectorsService;
            _countryService = countryService;
            _townService = townService;
        }


        public async Task<BusinessUser> FromModelAsync(UpdateBusinessUserViewModel model, Guid userId)
        {
            var businessUser = await _businessUserService.BusinessUserManager.FindByIdAsync(userId.ToString());

            businessUser.CompanyName = model.CompanyName;
            businessUser.AdditionalDescription = model.AdditionalDescription;

            if (model.ProfileImage != null)
            {
                businessUser.ProfileImageStr = ImageHelper.ImageToBase64(model.ProfileImage);
            }

            return businessUser;
        }
    


    public async Task<UpdateBusinessUserViewModel> CreateAsync(Guid userId)
        {

            var businessUser = await _businessUserService.BusinessUsers()
                .SingleAsync(x => x.Id == userId);

            var model = Mapper.Map<BusinessUser, UpdateBusinessUserViewModel>(businessUser);

            var businessSectors = await _businessSectorsService.GetPageAsync(0, int.MaxValue);
            var businessSectorItems = businessSectors.OrderBy(x => x.Position).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
            model.BusinessSectors = new SelectList(businessSectorItems, "Value", "Text");

            var countries = await _countryService.GetPageAsync(0, int.MaxValue);
            var countryItems = countries.OrderBy(x => x.Position).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
            model.Countries = new SelectList(countryItems, "Value", "Text");

            var towns = await _townService.GetPageAsync(0, int.MaxValue);
            var townItems = towns.OrderBy(x => x.Position).Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
            model.Towns = new SelectList(townItems, "Value", "Text");

            return model;
        }
    }
}
