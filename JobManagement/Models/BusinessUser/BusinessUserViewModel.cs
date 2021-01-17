namespace JobManagement.Models.BusinessUser
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Account;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Nomenclatures;
    using Resources;

    public class BusinessUserViewModel : BaseUserViewModel
    {
        [Display(Name = "CompanyName", ResourceType = typeof(AccountResource))]
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        public string CompanyName { get; set; }

        [Display(Name = "BusnessSector", ResourceType = typeof(AccountResource))]
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        public Guid NBusinessSectorId { get; set; }
        public SelectList BusinessSectors { get; set; }
        public NBusinessSector BusinessSector { get; set;}
        [Display(Name = "ProfilePicture", ResourceType = typeof(AccountResource))]
        public IFormFile ProfileImage { get; set; }
        
        [Display(Name = "AdditionalDescription", ResourceType = typeof(AccountResource))]
        public string AdditionalDescription { get; set; }

        [Display(Name = "Country", ResourceType = typeof(AccountResource))]
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        public Guid NCountryId { get; set; }
        public SelectList Countries { get; set; }
        public NCountry NCountry { get; set; }
        [Display(Name = "Town", ResourceType = typeof(AccountResource))]
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        public Guid NTownId { get; set; }
        public SelectList Towns { get; set; }
        public NTown NTown { get; set; }

    }
}