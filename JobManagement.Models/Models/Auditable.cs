namespace JobManagement.Models.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Auditable : IAuditable
    {
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        [ForeignKey("CreatedBy")]
        public BaseUser CreatedByUser { get; set; }
        public Guid CreatedBy { get; set; }

        [ForeignKey("ModifiedBy")]
        public BaseUser ModifiedByUser { get; set; }
        public Guid ModifiedBy { get; set; }
    }
}