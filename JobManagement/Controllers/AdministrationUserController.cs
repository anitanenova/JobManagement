namespace JobManagement.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Models.Account;
    using Services;

    [Authorize]
    public class AdministrationUserController : Controller
    {
        //private readonly IUserService _userService;

        //public AdministrationUserController(IUserService userService)
        //{
        //    _userService = userService;
        //}

        [HttpGet]
        public IActionResult AdministrationUser()
        {
            var administrationUserInfo = new AdministrationUserViewModel()
            {
                ProfileImage = "<img class=\"profil-picture\" src=\"~/img/job4.png\" />",
                Name = "Йоана"

            };

            return View(administrationUserInfo);
        }

        [HttpPost]
        public IActionResult AdministrationUser(AdministrationUserViewModel administrationUser)
        {
            return View(administrationUser);
        }

        [HttpGet]
        public IActionResult AdministrationUserRedaction()
        {
            return View();
        }
    }
}
