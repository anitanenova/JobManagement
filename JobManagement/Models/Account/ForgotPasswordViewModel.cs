#region Using

#endregion

namespace JobManagement.Models.Account
{
    using System.ComponentModel.DataAnnotations;

    public class ForgotPasswordViewModel :BaseUserViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string ReturnUrl { get; set; }
    }
}
