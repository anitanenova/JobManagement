 namespace JobManagement.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using System.Web;
    using AutoMapper;
    using BusinessManagement.Services.Model;
    using Constants;
    using Extensions;
    using Factories;
    using Factories.Interfaces;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Models;
    using Models.Account;
    using Models.Models;
    using Resources;
    using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

    using Services;
   

    [Authorize]
    public class AccountController : Controller
    {

        private readonly SignInManager<BaseUser> _signInManager;
        private readonly UserManager<BaseUser> _baseUserManager;
        private readonly IRegistrationUserViewModelFactory _registrationUserViewModelFactory;
        private readonly IRegistrationBusinessUserViewModelFactory _registrationBusinessUserViewModelFactory;
        //private readonly IEmailSenderService _emailSenderService;

        public AccountController(SignInManager<BaseUser> signInManager,
            UserManager<BaseUser> baseUserManager,
            IUserService userService,
            IBusinessSectorsService businessSectorsService,
            IGenderService genderService,
            IRegistrationUserViewModelFactory registrationUserViewModelFactory,
            IRegistrationBusinessUserViewModelFactory registrationBusinessUserViewModelFactory/*, IEmailSenderService emailSenderService*/)
        {
            _signInManager = signInManager;
            _baseUserManager = baseUserManager;
            _registrationUserViewModelFactory = registrationUserViewModelFactory;
            _registrationBusinessUserViewModelFactory = registrationBusinessUserViewModelFactory;
            //_emailSenderService = emailSenderService;
        }

        [HttpGet, AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl = null)
        {
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);
            var model = new LoginViewModel();
            return View(model);
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        //{

        //    if (!ModelState.IsValid)
        //    {
        //        return View("ForgotPassword", model);
        //    }
        //    var user = await _userService.UserManager.FindByEmailAsync(model.Email);
        //    if (user == null)
        //    {
        //        ModelState.AddModelError(string.Empty, AccountResource.UserNotFound);
        //    }

        //    var securityCode = await _userService.UserManager.GeneratePasswordResetTokenAsync(user);
        //    var name = user.Name == null ? user.UserName : user.Name + " " + user.LastName;

        //    var callbackUrl =
        //        $"{Request.Scheme}://{Request.Host}/Account/SetPasswordFromForgotten?code={HttpUtility.UrlEncode(securityCode)}&userId={user.Id}&returnUrl={HttpUtility.UrlEncode(model.ReturnUrl)}";

        //    await _emailSenderService.SendAsync(new Email
        //    {
        //        Body = _emailSenderService.GetEmailBody(callbackUrl, AccountResource.ForgotPasswordEmailMsg, String.Empty, $"Здравейте {name}, "),
        //        IsBodyHTML = true,
        //        RecipientEmail = model.Email,
        //        RecipientName = name,
        //        Subject = AccountResource.ForgotPasswordEmailSubject
        //    });


        //    return RedirectToAction("Index", "Notification");
        //    //new
        //    //{
            //    type = NotificationTypeEnim.Success,
            //    message = AccountResource.ResetPasswordLinkSendedMsg,
            //    header = AccountResource.CheckYourEmail
            //});

        //}

    //[HttpGet]
    //public async Task<IActionResult> SetPasswordFromForgotten(string code, Guid userId, string returnUrl)
    //{
    //    var user = await _baseUserManager.FindByIdAsync(userId.ToString());

    //    var isCodeValid = await _baseUserManager.VerifyUserTokenAsync(user, _baseUserManager.Options.Tokens.PasswordResetTokenProvider, UserManager<User>.ResetPasswordTokenPurpose, code);

    //    if (!isCodeValid)
    //    {
    //        //Невалиден код
    //        return RedirectToAction();
    //    }

    //var model = new SetPasswordViewModel
    //{
    //    SecurityCode = code,
    //    UserId = userId,
    //    Email = user.UserName,
    //    ReturnUrl = returnUrl,
    //    SetPasswordAction = "SetPasswordFromForgotten"
    //};
    //   return View("SetMemberPassword", model);
    //}

    //[HttpPost]
    //public async Task<IActionResult> SetPasswordFromForgotten([FromForm]SetPasswordViewModel model)
    //{
    //    if (!ModelState.IsValid)
    //    {
    //        return View("SetMemberPassword", model);
    //    }

    //    var user = await _userManager.FindByIdAsync(model.UserId.ToString());

    //    var isCodeValid = await _userManager.VerifyUserTokenAsync(user, _userManager.Options.Tokens.PasswordResetTokenProvider, UserManager<User>.ResetPasswordTokenPurpose, model.SecurityCode);

    //    if (!isCodeValid)
    //    {

    //    }

    //    var responce = await _userManager.ResetPasswordAsync(user, model.SecurityCode, model.Password);

    //    if (!responce.Succeeded)
    //    {
    //        foreach (var responceError in responce.Errors)
    //        {
    //            ModelState.AddModelError(string.Empty, responceError.Description);
    //        }
    //        return View("SetMemberPassword", model);
    //    }
    //    return RedirectToAction("Login", new { returnUrl = model.ReturnUrl });
    //}

    private async Task LoginUserAsync(BaseUser user, bool rememberMe)
        {
            var claimsPrincipal = await _signInManager.CreateUserPrincipalAsync(user);

            var customClaims = new[]
            {
                new Claim(UserConstants.USER_TYPE_CLAIM, user.UserType.ToString()),
                new Claim(UserConstants.USER_ID_CLAIM, user.Id.ToString())

            };

            if (claimsPrincipal?.Identity is ClaimsIdentity claimsIdentity)
            {
                claimsIdentity.AddClaims(customClaims);
            }

            await _signInManager.Context.SignInAsync(IdentityConstants.ApplicationScheme,
                claimsPrincipal,
                new AuthenticationProperties {IsPersistent = rememberMe});
        }
        
        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _baseUserManager.FindByEmailAsync(model.Email);
            var passwordIsCorrect = await _baseUserManager.CheckPasswordAsync(user, model.Password);

            if (user != null && passwordIsCorrect)
            {
                await LoginUserAsync(user, model.RememberMe);
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError(string.Empty, "Невалидно име или парола");
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }


        [HttpGet, AllowAnonymous]
        public IActionResult ChoiseTypeRegistration()
        {
            return View();
        }

        [HttpGet, AllowAnonymous]
        public async Task<IActionResult> UserRegister()
        {
            var model = await _registrationUserViewModelFactory.CreateAsync();
            return View(model);
        }

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<IActionResult> UserRegister(RegistrationUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var newModel = await _registrationUserViewModelFactory.CreateAsync();
                Mapper.Map(model, newModel);
                return View(newModel);
            }


            var user = Mapper.Map<RegistrationUserViewModel, User>(model);
            user.UserName = model.Email;

            var result = await _baseUserManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return View(model);
            }

            await LoginUserAsync(user, false);
            return RedirectToAction("Index", "Home");

        }

        [HttpGet, AllowAnonymous]
        public async Task<IActionResult> BusinessRegister()
        {
            var model = await _registrationBusinessUserViewModelFactory.CreateAsync();
            return View(model);
        }

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<IActionResult> BusinessRegister(RegistrationBusinessUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var newModel = await _registrationBusinessUserViewModelFactory.CreateAsync();
                Mapper.Map(model, newModel);
                return View(newModel);
            }

            var user = Mapper.Map<RegistrationBusinessUserViewModel, BusinessUser>(model);
            user.UserName = model.Email;
            user.NBusinessSector = null;

            var result = await _baseUserManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                return View(model);
            }

            await LoginUserAsync(user, false);
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        //[HttpPost]
        //[AllowAnonymous]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
        //{
        //    // Something failed, redisplay form
        //    if (!ModelState.IsValid)
        //        return View(model);

        //    // Check if the user exists in the data store
        //    var user = await _baseUserManager.FindByEmailAsync(model.Email);

        //    // If no user is found, or the user has not confirmed their email address yet
        //    if (user == null || !await _baseUserManager.IsEmailConfirmedAsync(user))
        //    {
        //        // Show the confirmation page either way
        //        return RedirectToAction(nameof(ForgotPasswordConfirmation));
        //    }

        //    // For more information on how to enable account confirmation and password reset please 
        //    // visit https://go.microsoft.com/fwlink/?LinkID=532713
        //  //  var code = await _baseUserManager.GeneratePasswordResetTokenAsync(user);
        //  //  var callbackUrl = Url.ResetPasswordCallbackLink(user.Id, code, Request.Scheme);

        //    // Note: This should usually send out the email address but the default implementation for the EmailSender is empty
        //  // await _emailSenderService.SendAsync(model.Email, "Reset Password", $"Please reset your password by clicking here: <a href='{callbackUrl}'>link</a>");

        //  //  Show the confirmation page
        //    return RedirectToAction(nameof(ForgotPasswordConfirmation));
        //}

        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

      
        [HttpGet, AllowAnonymous]
        public IActionResult ResetPassword()
        {
            var model = new ResetPasswordViewModel();
            return View(model);
        }

        //[HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        //public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

            //to do .ChangePasswordFromForgotten !!!!!!!

            //var user = Mapper.Map<ResetPasswordViewModel,>(model);
            //user.UserName = model.Email;

            //var result = await _baseUserManager.CheckPasswordAsync(user, password: model.Password);
            //if (!result.Succeeded)
            //{
            //    foreach (var error in result.Errors)
            //    {
            //        ModelState.AddModelError(string.Empty, error.Description);
            //    }
            //    return View(model);
            //}

            //await LoginUserAsync(user, false);
            //return RedirectToAction("Index", "Home");


        }
}

