namespace JobManagement.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    
    public class BazarController : Controller
    {
       public IActionResult Bazar()
        {
            return View();
        }
    }
}
