namespace JobManagement.Models.Account
{
    using System.ComponentModel.DataAnnotations;
    using Resources;

    public class AdministrationUserViewModel : BaseUserViewModel
    {

        [Display(Name = "Name", ResourceType = typeof(AccountResource))]
        public string Name { get; set; }

        public string ProfileImage { get; set; }
    }
}
