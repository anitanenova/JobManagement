using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobManagement.Factories
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Models.BusinessUser;
    using Models.Models;
    using Models.User;
    using Services;

    public static class BusinessUserInformationViewModelFactory
    {

        public static async Task<BusinessUserInformationViewModel> CreateAsync(IBusinessUserService businessUserService, Guid userId)
        {
            var user = await businessUserService.BusinessUsers()
                .Include(x => x.NBusinessSector)
                .Include(x => x.NCountry)
                .Include(x => x.NTown)
                .SingleAsync(x => x.Id == userId);

            var model = Mapper.Map<BusinessUser, BusinessUserInformationViewModel>(user);
            return model;
        }
    }
}
