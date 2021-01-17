namespace JobManagement.Models.Nomenclatures
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Models;

   public class NBusinessSector
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public int Position { get; set; }

        public List<BusinessUser> BusinessUsers { get; set; }
    }
}
