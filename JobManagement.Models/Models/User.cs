namespace JobManagement.Models.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Nomenclatures;

    public class User: BaseUser
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        public DateTime BdayDate { get; set; }
        public string ProfileImageStr { get; set; }
        [MaxLength(255)]
        public string TelеphoneNumber { get; set; }
        public bool VisibilityProfile { get; set; }
        [Required]
        [ForeignKey("NCountryUserId")]
        public Guid NCountryId { get; set; }
        [ForeignKey("NCountrynUser")]
        public NCountry NCountry { get; set; } = new NCountry();
  
        public string AdditionalDescription { get; set; }
        [ForeignKey("UserId")]
        public ICollection<GalleryImage> GalleryImages { get; set; } = new List<GalleryImage>();
        public Guid? NEducationId { get; set; }
        public NEducation NEducation { get; set; } = new NEducation();
        public Guid NGenderId { get; set; }
        public NGender NGender { get; set; } = new NGender();
        [Required]
        [ForeignKey("NTownUserId")]
        public Guid NTownId { get; set; }
        [ForeignKey("NTownUser")]
        public NTown NTown { get; set; } = new NTown();
        public ICollection<UserNSkill> UserNSkills { get; set; } = new List<UserNSkill>();
        public ICollection<UserNCategory> UserNCategories { get; set; } = new List<UserNCategory>();
        public ICollection<UserNJobType> UserNJobTypes { get; set; } = new List<UserNJobType>();
        public ICollection<UserNHealthStatus> UserNHealthStatuses { get; set; } = new List<UserNHealthStatus>();
        public ICollection<GalleryImage> CreatedByGalleryImages { get; set; } = new List<GalleryImage>();
        public ICollection<GalleryImage> ModifiedByGalleryImages { get; set; } = new List<GalleryImage>();
    }
}