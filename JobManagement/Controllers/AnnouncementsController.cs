namespace JobManagement.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class AnnouncementsController : Controller
    {
        public IActionResult Announcements()
        {
            return View();
        }
    }
}
