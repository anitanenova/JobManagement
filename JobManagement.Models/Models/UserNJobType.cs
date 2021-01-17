using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagement.Models.Models
{
    using Nomenclatures;

    public class UserNJobType
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = new User();
        public Guid NJobTypeId { get; set; }
        public  NJobType NJobType { get; set; } = new NJobType();
    }
}
