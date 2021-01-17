namespace JobManagement.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Models.Models;

    public class UserService : IUserService
    {
        private readonly JobManagementDbContext _dbContext;
        public UserService(UserManager<User> userManager, JobManagementDbContext dbContext)
        {
            UserManager = userManager;
            _dbContext = dbContext;
        }
        public UserManager<User> UserManager { get;  }


        public async Task Update(User user)
        {
            var userSkills = await _dbContext.UsersNSkills.Where(x => x.UserId == user.Id).ToListAsync();
            _dbContext.UsersNSkills.RemoveRange(userSkills);

            var userCategories = await _dbContext.UserNCategories.Where(x => x.UserId == user.Id).ToListAsync();
            _dbContext.UserNCategories.RemoveRange(userCategories);

            var userJobTypes = await _dbContext.UserNJobTypes.Where(x => x.UserId == user.Id).ToListAsync();
            _dbContext.UserNJobTypes.RemoveRange(userJobTypes);

            var userHealthStatuses = await _dbContext.UserNHealthStatuses.Where(x => x.UserId == user.Id).ToListAsync();
            _dbContext.UserNHealthStatuses.RemoveRange(userHealthStatuses);

            _dbContext.Users.Update(user);
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<User> Users()
        {
            return _dbContext.Users;
        }
    }
}