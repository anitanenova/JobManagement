namespace JobManagement.Factories.Interfaces
{
    using System;
    using System.Threading.Tasks;
    using Models.User;

    public interface IUserGalleryViewModelFactory
    {
        Task<UserGalleryViewModel> CreateAsync(int skip, int take);
    }
}