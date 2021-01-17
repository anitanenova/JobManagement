namespace JobManagement.Models.Account
{
    using System.ComponentModel.DataAnnotations;
    using Resources;

    public class UserVideoModel
    {
        [Display(Name = "Video", ResourceType = typeof(AccountResource))]
        public string UserVideo { get; set; }
    }
}
