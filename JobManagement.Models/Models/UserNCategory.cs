namespace JobManagement.Models.Models
{
    using System;
    using Nomenclatures;

   public class UserNCategory
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = new User();
        public Guid NCategoryId { get; set; }
        public NCategory NCategory { get; set; } = new NCategory();
    }
}
