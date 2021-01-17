namespace JobManagement.Controllers
{
    using System.Diagnostics;
    using Attributes;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Models.Enums;

    public class HomeController : Controller
    {
       // [AuthorizeByType(UserTypeEnum.BusinessUser, UserTypeEnum.User)]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
