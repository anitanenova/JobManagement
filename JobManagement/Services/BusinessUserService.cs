namespace JobManagement.Services
{
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using Microsoft.AspNetCore.Identity;
    using Models.Models;

    public class BusinessUserService : IBusinessUserService
    {
        private readonly JobManagementDbContext _dbContext;
        public BusinessUserService(UserManager<BusinessUser> userManager, JobManagementDbContext dbContext)
        {
            BusinessUserManager = userManager;
            _dbContext = dbContext;
        }
        public UserManager<BusinessUser> BusinessUserManager { get; }

        public async Task Update(BusinessUser businessUser)
        {
            _dbContext.BusinessUsers.Update(businessUser);
            await _dbContext.SaveChangesAsync();
        }
        public IQueryable<BusinessUser> BusinessUsers()
        {
            return _dbContext.BusinessUsers;
        }
    }
}
