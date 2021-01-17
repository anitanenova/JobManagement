namespace JobManagement.Factories.Interfaces
{
    using System;
    using System.Threading.Tasks;
    using Models.BusinessUser;
    using Models.Models;

    public interface IUpdateBusinessUserViewModelFactory
    {
        Task<BusinessUser> FromModelAsync(UpdateBusinessUserViewModel model, Guid userId);
        Task<UpdateBusinessUserViewModel> CreateAsync(Guid userId);
    }
}
