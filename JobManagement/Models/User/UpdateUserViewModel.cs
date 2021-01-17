namespace JobManagement.Models.User
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Mvc.Rendering;
    using Nomenclatures;
    using Resources;

    public class UpdateUserViewModel: UserViewModel
    {
        [Display(Name = "Education", ResourceType = typeof(AccountResource))]
        public Guid? NEducationId { get; set; } = null;
        public SelectList Educations { get; set; }
        [Display(Name = "Gender", ResourceType = typeof(AccountResource))]
        public Guid NGenderId { get; set; }
        public SelectList Genders { get; set; }
        [Display(Name = "Country", ResourceType = typeof(AccountResource))]
        public Guid NCountryId { get; set; }
        public SelectList Countries { get; set; }
        [Display(Name = "Town", ResourceType = typeof(AccountResource))]
        public Guid NTownId { get; set; }
        public SelectList Towns { get; set; }
        public List<Filter> Skills { get; set; } = new List<Filter>();
        public List<Filter> Categories { get; set; } = new List<Filter>();
        public List<Filter> JobTypes { get; set; } = new List<Filter>();
        public List<Filter> HealthStatuses { get; set; } = new List<Filter>();

    }
}
