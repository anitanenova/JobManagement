namespace JobManagement.Models.BusinessUser
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Account;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Resources;

    public class UpdateBusinessUserViewModel : BusinessUserViewModel
    {
        [Display(Name = "BusinessSector", ResourceType = typeof(AccountResource))]
        public Guid NBusinessSectorId { get; set; }
        public SelectList BusinessSector { get; set; }

        [Display(Name = "Country", ResourceType = typeof(AccountResource))]
        public Guid NCountryId { get; set; }
        public SelectList Countries { get; set; }

        [Display(Name = "Town", ResourceType = typeof(AccountResource))]
        public Guid NTownId { get; set; }
        public SelectList Towns { get; set; }
    }
}
