namespace JobManagement.Models.User
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Account;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Nomenclatures;
    using Resources;

    public class UserViewModel : BaseUserViewModel
    {
        [Display(Name = "Video", ResourceType = typeof(AccountResource))]
        public UserVideoModel UserVideo { get; set; }

        [Display(Name = "Name", ResourceType = typeof(AccountResource))]
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        public string Name { get; set; }

        [Display(Name = "LastName", ResourceType = typeof(AccountResource))]
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        public string LastName { get; set; }

        [Display(Name = "Gender", ResourceType = typeof(AccountResource))]
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        public Guid? NGenderId { get; set; } = null;
       public SelectList Genders { get; set; }
       
        public NGender NGender { get; set; }

        [Display(Name = "BdayDate", ResourceType = typeof(AccountResource))]
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        public DateTime? BdayDate { get; set; }

       [Display(Name = "ProfilePicture", ResourceType = typeof(AccountResource))]
        public IFormFile ProfileImage { get; set; }

        [Display(Name = "GalleryImages", ResourceType = typeof(AccountResource))]
        public List<IFormFile> GalleryImages { get; set; } = new List<IFormFile>();

        [Display(Name = "Categories", ResourceType = typeof(AccountResource))]
        public string Categories { get; set; }

        [Display(Name = "JobType", ResourceType = typeof(AccountResource))]
        public string JobType { get; set; }

        [Display(Name = "Skills", ResourceType = typeof(AccountResource))]
        public string Skills { get; set; }

        [Display(Name = "HealthStatus", ResourceType = typeof(AccountResource))]
        public string HealthStatus { get; set; }

        [Display(Name = "TelNumber", ResourceType = typeof(AccountResource))]
        public string TelеphoneNumber { get; set; }

        [Display(Name = "VisibleProfile", ResourceType = typeof(AccountResource))]
        public bool VisibilityProfile { get; set; }
        
        [Display(Name = "Country", ResourceType = typeof(AccountResource))]
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        public Guid? NCountryId { get; set; } = null;
        public SelectList Countries { get; set; }
        public NCountry NCountry { get; set; }

        [Display(Name = "Town", ResourceType = typeof(AccountResource))]
        [Required(ErrorMessageResourceType = typeof(SharedResource), ErrorMessageResourceName = "RequiredField")]
        public Guid? NTownId { get; set; } = null;
        public SelectList Towns { get; set; }
        public NTown NTown { get; set; }

        [Display(Name = "AdditionalDescription", ResourceType = typeof(AccountResource))]
        public string AdditionalDescription { get; set; }
       

    }
}