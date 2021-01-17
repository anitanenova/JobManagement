namespace JobManagement.Controllers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;

    using Extensions;
    using Factories;
    using Factories.Interfaces;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Models.Account;
    using Models.User;
    using Services;

    [Authorize]
    public class UserController : Controller
    {
        private readonly IUpdateUserViewModelFactory _updateUserViewModelFactory;
        private readonly IUserService _userService;
        private readonly IUserGalleryViewModelFactory _galleryViewModelFactory;
        private readonly IGalleryService _galleryService;

        public UserController(
            IUpdateUserViewModelFactory updateUserViewModelFactory,
            IUserService userService,
            IUserGalleryViewModelFactory galleryViewModelFactory, 
            IGalleryService galleryService)
        {
            _updateUserViewModelFactory = updateUserViewModelFactory;
            _userService = userService;
            _galleryViewModelFactory = galleryViewModelFactory;
            _galleryService = galleryService;
        }

      
        [HttpGet]
        public async Task<IActionResult> UserProfile()
        {
            var userId = User.GetId();
            var userImage = await _userService.Users().Where(x => x.Id == userId).Select(x=>x.ProfileImageStr).SingleOrDefaultAsync();

            var model = new UserProfileViewModel
            {
                UserInformationModel = await UserInformationViewModelFactory.CreateAsync(_userService, User.GetId()),
                ProfileImageStr = userImage
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> UserInfo()
        {
            var model = await UserInformationViewModelFactory.CreateAsync(_userService, User.GetId());
            return PartialView("_UserInformation", model);
        }
        
        [HttpGet]
        public async Task<ActionResult> UserGallery()
        {
            var model = await _galleryViewModelFactory.CreateAsync(0, 15);
            return PartialView("_UserGallery", model);
        }

        [HttpGet]
        public async Task<ActionResult> UserGalleryImages(int skip, int take)
        {
            var model = await _galleryViewModelFactory.CreateAsync(skip, take);
            return PartialView("_UserGalleryImages", model);
        }

        public IActionResult UserVideo()
        {
            return PartialView("_UserVideo");
        }

        [HttpGet]
        public async Task<ActionResult> GetGalleryImages(int skip, int take)
        {
            var model = await _galleryViewModelFactory.CreateAsync(skip, take);
            return PartialView("_GalleryImages", model);
        }

        public async Task<IActionResult> UpdateUser()
        {
            var model = await _updateUserViewModelFactory.CreateAsync(User.GetId());
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(UpdateUserViewModel model)
        {
            var user = await _updateUserViewModelFactory.FromModelAsync(model, User.GetId());

            await _userService.Update(user);
            return RedirectToAction("UserProfile", "User");
        }
    }
}