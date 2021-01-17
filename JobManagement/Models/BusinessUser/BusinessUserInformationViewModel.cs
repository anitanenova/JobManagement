using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobManagement.Models.BusinessUser
{
    using Nomenclatures;

    public class BusinessUserInformationViewModel : BusinessUserViewModel
    {
        public NBusinessSector NBusinessSector { get; set; }
        public NCountry NCountry { get; set; }
        public NTown NTown { get; set; }
    }
}
