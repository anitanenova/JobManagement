namespace JobManagement.Models.Account
{
    using System.ComponentModel.DataAnnotations;
    using Resources;

    public class BaseUserViewModel
    {
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        [EmailAddress(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "InvalidEmailMsg")]
        [Display(Name = "Email", ResourceType = typeof(AccountResource))]
        public string Email { get; set; }
    }
}