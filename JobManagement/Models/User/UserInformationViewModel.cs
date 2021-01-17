namespace JobManagement.Models.User
{
    using System.Collections.Generic;
    using Nomenclatures;

    public class UserInformationViewModel: UserViewModel
    {
        public NEducation NEducation { get; set; }
        public NGender NGender { get; set; }
        public NCountry NCountry { get; set; }
        public NTown NTown { get; set; }
        public List<NSkill> Skills { get; set; }
        public List<NHealthStatus> HealthStatus { get; set; }
        public List<NCategory> Categories { get; set; }
        public List<NJobType> JobTypes { get; set; }
    }
}