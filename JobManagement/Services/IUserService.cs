namespace JobManagement.Services
{
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Models.Models;

    public interface IUserService
    {
        UserManager<User> UserManager { get; }
        IQueryable<User> Users();
        Task Update(User user);
    }
}