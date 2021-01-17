using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobManagement.Models.BusinessUser
{
    public class BusinessUserProfileViewModel
    {
        public BusinessUserInformationViewModel BusinessUserInformationModel { get; set; }
        public string ProfileImageStr { get; set; }
    }
}
