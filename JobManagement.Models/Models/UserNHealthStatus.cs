namespace JobManagement.Models.Models
{
    using System;
    using Nomenclatures;

    public class UserNHealthStatus
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = new User();
        public Guid NHealthStatusId { get; set; }
        public NHealthStatus NHealthStatus { get; set; } = new NHealthStatus();
    }
}
