namespace JobManagement.Controllers
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using Extensions;
    using Factories;
    using Factories.Interfaces;
    using Helper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using Models.Account;
    using Models.BusinessUser;
    using Models.Models;
    using Services;

    [Authorize]
    public class BusinessUserController : Controller
    {
        private readonly IUpdateBusinessUserViewModelFactory _updateBusinessUserViewModelFactory;
        private readonly SignInManager<BaseUser> _signInManager;
        private readonly IBusinessUserService _businessUserService;

        public BusinessUserController(SignInManager<BaseUser> signInManager, IBusinessUserService businessUserService, IUpdateBusinessUserViewModelFactory updateBusinessUserViewModelFactory)
        {
            _signInManager = signInManager;
            _businessUserService = businessUserService;
            _updateBusinessUserViewModelFactory = updateBusinessUserViewModelFactory;
        }

        [HttpGet]
        public async Task<IActionResult> BusinessUser()
        {

            var userId = User.GetId();
            var userImage = await _businessUserService.BusinessUsers().Where(x => x.Id == userId).Select(x => x.ProfileImageStr).SingleOrDefaultAsync();

            var model = new BusinessUserProfileViewModel
            {
                BusinessUserInformationModel = await BusinessUserInformationViewModelFactory.CreateAsync(_businessUserService, User.GetId()),
                ProfileImageStr = userImage
            };

            return View(model);

        }


        [HttpGet]
        public async Task<IActionResult> BusinessUserInfo()
        {
            var model = await BusinessUserInformationViewModelFactory.CreateAsync(_businessUserService, User.GetId());
            return PartialView("_BusinessUserInformation", model);
        }

        [HttpGet]
        public async Task<IActionResult> BusinessUserEdit()
        {
            var model = await _updateBusinessUserViewModelFactory.CreateAsync(User.GetId());
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> BusinessUserEdit(UpdateBusinessUserViewModel model)
        {
            var businessUser = await _updateBusinessUserViewModelFactory.FromModelAsync(model, User.GetId());
            await _businessUserService.Update(businessUser);
            return RedirectToAction("BusinessUser", "BusinessUser");
        }
    }
}

