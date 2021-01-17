namespace JobManagement.Models.Models
{
    using System;
    using Nomenclatures;

    public class UserNSkill
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = new User();
        public Guid NSkillId { get; set; }
        public NSkill NSkill { get; set; } = new NSkill();
    }
}