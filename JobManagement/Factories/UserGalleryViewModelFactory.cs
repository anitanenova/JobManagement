namespace JobManagement.Factories
{
    using System;
    using System.Threading.Tasks;

    using AutoMapper;
    using Interfaces;
    using Microsoft.EntityFrameworkCore;
    using Models.Models;
    using Models.User;
    using Services;

    public class UserGalleryViewModelFactory : IUserGalleryViewModelFactory
    {
        private readonly IGalleryService _galleryService;

        public UserGalleryViewModelFactory(IGalleryService galleryService)
        {
            _galleryService = galleryService;
        }

        public async Task<UserGalleryViewModel> CreateAsync(int skip, int take)
        {
            var model = new UserGalleryViewModel
            {
                GalleryImages = await _galleryService.GetAsync(skip, take)
            };
            return model;
        }

    }
}
