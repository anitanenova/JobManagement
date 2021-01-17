namespace JobManagement.Models.Account
{
    using System.ComponentModel.DataAnnotations;
    using Resources;

    public class ResetPasswordViewModel
    {
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        [Display(Name = "Password", ResourceType = typeof(AccountResource))]
        public string Password { get; set; }


        [Display(Name = "ConformPassword", ResourceType = typeof(AccountResource))]
        [Compare(nameof(Password), ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        public string ConfirmPassword { get; set; }
    }
}
