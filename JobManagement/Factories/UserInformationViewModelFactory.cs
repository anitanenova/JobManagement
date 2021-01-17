namespace JobManagement.Factories
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Models.Models;
    using Models.Nomenclatures;
    using Models.User;
    using Services;

    public static class UserInformationViewModelFactory
    {
        public static async Task<UserInformationViewModel> CreateAsync(IUserService userService, Guid userId)
        {
            var user = await userService.Users()
                .Include(x => x.NEducation)
                .Include(x=>x.UserNSkills).ThenInclude(x=>x.NSkill)
                .Include(x=>x.UserNHealthStatuses).ThenInclude(x=>x.NHealthStatus)
                .Include(x=>x.UserNCategories).ThenInclude(x=>x.NCategory)
                .Include(x=>x.UserNJobTypes).ThenInclude(x=>x.NJobType)
                .Include(x=>x.NGender)
                .Include(x=>x.NCountry)
                .Include(x=>x.NTown)
                .SingleAsync(x => x.Id == userId);

           
            var model = Mapper.Map<User, UserInformationViewModel>(user);
            model.Skills = user.UserNSkills.Select(x => x.NSkill).ToList();
            model.HealthStatus = user.UserNHealthStatuses.Select(x => x.NHealthStatus).ToList();
            model.Categories = user.UserNCategories.Select(x => x.NCategory).ToList();
            model.JobTypes = user.UserNJobTypes.Select(x => x.NJobType).ToList();
            return model;
        }
    }
}