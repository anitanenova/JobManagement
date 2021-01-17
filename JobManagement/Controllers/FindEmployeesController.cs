namespace JobManagement.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class FindEmployeesController : Controller
    {
        public IActionResult FindEmployees()
        {
            return View();
        }

    }
}
