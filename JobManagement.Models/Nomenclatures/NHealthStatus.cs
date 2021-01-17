using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagement.Models.Nomenclatures
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Models;

   public class NHealthStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public int Position { get; set; }
        public List<UserNHealthStatus> UserNHealthStatus { get; set; } = new List<UserNHealthStatus>();
    }
}
