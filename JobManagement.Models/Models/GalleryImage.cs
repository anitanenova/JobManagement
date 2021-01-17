namespace JobManagement.Models.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class GalleryImage: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string Image { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; } = new User();


    }
}