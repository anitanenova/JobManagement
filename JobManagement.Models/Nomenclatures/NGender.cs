namespace JobManagement.Models.Nomenclatures
{
    using System;
    using System.Collections.Generic;

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Models;

   public class NGender
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public int Position { get; set; }

        public List<User> Users { get; set; }= new List<User>();
    }
}
