namespace JobManagement.Models.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Nomenclatures;

    public class BusinessUser: BaseUser
    {
        [Required]
        [MaxLength(100)]
        public string CompanyName { get; set; }

        public string ProfileImageStr { get; set; }
        [Required]
        [ForeignKey("NCountryBusinessUserId")]
        public Guid NCountryId { get; set; }
        [ForeignKey("NCountryBusinessnUser")]
        public NCountry NCountry { get; set; } = new NCountry();
        [Required]
        [ForeignKey("NTownBusinessUserId")]
        public Guid NTownId { get; set; }
        [ForeignKey("NTownBusinessUser")]
        public NTown NTown { get; set; } = new NTown();

        public string AdditionalDescription { get; set; }


        public NBusinessSector NBusinessSector { get; set; } = new NBusinessSector();
        public Guid NBusinessSectorId { get; set; }
    }
}