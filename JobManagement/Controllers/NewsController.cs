namespace JobManagement.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class NewsController : Controller
    {
        public IActionResult News()
        {
            return View();
        }
    }
}
