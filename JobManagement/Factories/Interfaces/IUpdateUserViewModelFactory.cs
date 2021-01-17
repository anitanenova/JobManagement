namespace JobManagement.Factories.Interfaces
{
    using System;
    using System.Threading.Tasks;
    using Models.Models;
    using Models.User;

    public interface IUpdateUserViewModelFactory
    {
        Task<User> FromModelAsync(UpdateUserViewModel model, Guid userId);
        Task<UpdateUserViewModel> CreateAsync(Guid userId);
    }
}