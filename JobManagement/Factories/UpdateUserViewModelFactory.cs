namespace JobManagement.Factories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using Models.Models;
    using Models.User;
    using Services;
    using Helper;
    using Interfaces;

    public class UpdateUserViewModelFactory : IUpdateUserViewModelFactory
    {

        private readonly IUserService _userService;
        private readonly ISkillService _skillService;
        private readonly ICategoryService _categoryService;
        private readonly IJobTypeService _jobTypeService;
        private readonly IHealthStatusService _healthStatusService;
        private readonly IGenderService _genderService;
        private readonly IEducationsService _educationsService;
        private readonly ICountryService _countryService;
        private readonly ITownService _townService;
        private readonly IGalleryService _galleryService;

        public UpdateUserViewModelFactory(IUserService userService, ISkillService skillService, ICategoryService categoryService, IJobTypeService jobTypeService, IHealthStatusService healthStatusService, IGenderService genderService, IEducationsService educationsService, IGalleryService galleryService, ICountryService countryService, ITownService townService)
        {
            _userService = userService;
            _skillService = skillService;
            _categoryService = categoryService;
            _jobTypeService = jobTypeService;
            _healthStatusService = healthStatusService;
            _genderService = genderService;
            _educationsService = educationsService;
            _galleryService = galleryService;
            _countryService = countryService;
            _townService = townService;
        }


        public async Task<User> FromModelAsync(UpdateUserViewModel model, Guid userId)
        {
            var user = await _userService.UserManager.FindByIdAsync(userId.ToString());

            user.AdditionalDescription = model.AdditionalDescription;
            user.BdayDate = model.BdayDate.Value;
            user.LastName = model.LastName;
            user.Name = model.Name;
            user.TelеphoneNumber = model.TelеphoneNumber;
            user.Email = model.Email;
            
            if (model.ProfileImage != null)
            {
               user.ProfileImageStr = ImageHelper.ImageToBase64(model.ProfileImage);
            }
            
            
            foreach (var imageGallery in model.GalleryImages)
            {
                var imageStr = ImageHelper.ImageToBase64(imageGallery);

                var galleryImage = new GalleryImage
                {
                    Image = imageStr
                };

                user.GalleryImages.Add(galleryImage);
            }
            
            var skills = await _skillService.GetAsync(model.Skills.Where(x => x.IsSelected).Select(x => x.Id).ToList());

            user.UserNSkills = new List<UserNSkill>();
            foreach (var skill in skills)
            {
                user.UserNSkills.Add(new UserNSkill
                {
                    NSkillId = skill.Id,
                    NSkill = skill
                });
            }

            var categories = await _categoryService.GetAsync(model.Categories.Where(x => x.IsSelected).Select(x => x.Id).ToList());

            user.UserNCategories = new List<UserNCategory>();
            foreach (var category in categories)
            {
                user.UserNCategories.Add(new UserNCategory
                {
                    NCategoryId = category.Id,
                    NCategory = category
                });
            }

            var jobTypes = await _jobTypeService.GetAsync(model.JobTypes.Where(x => x.IsSelected).Select(x => x.Id).ToList());

            user.UserNJobTypes = new List<UserNJobType>();
            foreach (var jobType in jobTypes)
            {
                user.UserNJobTypes.Add(new UserNJobType
                {
                    NJobTypeId = jobType.Id,
                    NJobType = jobType
                });
            }

            var healthStatuses = await _healthStatusService.GetAsync(model.HealthStatuses.Where(x => x.IsSelected).Select(x => x.Id).ToList());

            user.UserNHealthStatuses = new List<UserNHealthStatus>();
            foreach (var healthStatus in healthStatuses)
            {
                user.UserNHealthStatuses.Add(new UserNHealthStatus
                {
                    NHealthStatusId = healthStatus.Id,
                    NHealthStatus = healthStatus
                });
            }
            return user;
        }

        public async Task<UpdateUserViewModel> CreateAsync(Guid userId)
        {
            var user = await _userService.Users().Include(x=>x.UserNSkills).Include(x=>x.UserNCategories).Include(x=>x.UserNJobTypes).Include(x=>x.UserNHealthStatuses)
                .SingleAsync(x => x.Id == userId);

            var model = Mapper.Map<User, UpdateUserViewModel>(user);
            
            var skills = await _skillService.GetPageAsync(0, int.MaxValue);
            model.Skills = skills.Select(skill => new Filter
            {
                Name = skill.Name,
                Id = skill.Id,
                IsSelected = user.UserNSkills.Any(userSkill => userSkill.NSkillId == skill.Id)
            }).ToList();

            var categories = await _categoryService.GetPageAsync(0, int.MaxValue);
            model.Categories = categories.Select(category => new Filter
            {
                Name = category.Name,
                Id = category.Id,
                IsSelected = user.UserNCategories.Any(userCategory => userCategory.NCategoryId == category.Id)
            }).ToList();

             var jobTypes = await _jobTypeService.GetPageAsync(0, int.MaxValue);
            model.JobTypes = jobTypes.Select(jobType => new Filter
            {
                Name = jobType.Name,
                Id = jobType.Id,
                IsSelected = user.UserNJobTypes.Any(userJobType => userJobType.NJobTypeId == jobType.Id)
            }).ToList();

            var healthStatuses = await _healthStatusService.GetPageAsync(0, int.MaxValue);
            model.HealthStatuses = healthStatuses.Select(healthStatus => new Filter
            {
                Name = healthStatus.Name,
                Id = healthStatus.Id,
                IsSelected = user.UserNHealthStatuses.Any(userHealthStatus => userHealthStatus.NHealthStatusId == healthStatus.Id)
            }).ToList();

            var educations = await _educationsService.GetPageAsync(0, int.MaxValue);
            var educationItems = educations.OrderBy(x=>x.Position).Select(x=> new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
            model.Educations = new SelectList(educationItems, "Value", "Text");

            var genders = await _genderService.GetPageAsync(0, int.MaxValue);
            var genderItems = genders.OrderBy(x=>x.Position).Select(x=> new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
            model.Genders = new SelectList(genderItems, "Value", "Text");

            var countries = await _countryService.GetPageAsync(0, int.MaxValue);
            var countryItems = countries.OrderBy(x=>x.Position).Select(x=> new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
            model.Countries = new SelectList(countryItems, "Value", "Text");

            var towns = await _townService.GetPageAsync(0, int.MaxValue);
            var townItems = towns.OrderBy(x=>x.Position).Select(x=> new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString(),
            });
            model.Towns = new SelectList(townItems, "Value", "Text");
            return model;
        }
    }
}