using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobManagement.Services
{
    using Microsoft.AspNetCore.Identity;
    using Models.Models;

    public interface IBusinessUserService
    {
        UserManager<BusinessUser> BusinessUserManager { get; }
        IQueryable<BusinessUser> BusinessUsers();
        Task Update(BusinessUser businessUser);
    }
}
