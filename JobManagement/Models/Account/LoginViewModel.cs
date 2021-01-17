namespace JobManagement.Models.Account
{
    using System.ComponentModel.DataAnnotations;

    using Resources;

    public class LoginViewModel
    {
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        [EmailAddress(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "InvalidEmailMsg")]
        [Display(Name = "Email", ResourceType = typeof(AccountResource))]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        [DataType(DataType.Password)]
        [Display(Name = "Password", ResourceType = typeof(AccountResource))]
        public string Password { get; set; }

        [Display(Name = "RememberMe", ResourceType = typeof(AccountResource))]
        public bool RememberMe { get; set; }
    }
}