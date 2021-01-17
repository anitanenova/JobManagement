namespace JobManagement.Controllers 
{
    using Attributes;
    using Microsoft.AspNetCore.Mvc;
    using Models.Enums;

    public class ApprovalController : Controller
    {
        [AuthorizeByType(UserTypeEnum.AdministrationUser)]
        public IActionResult ApprovalUsers()
        {
            return View();
        }
        public IActionResult ApprovalAnnouncements()
        {
            return View();
        }
    }
}
