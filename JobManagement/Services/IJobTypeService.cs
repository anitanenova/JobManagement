using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobManagement.Services
{
    using Models.Nomenclatures;

    public interface IJobTypeService
    {
        Task<List<NJobType>> GetPageAsync(int skip, int take);
        Task<List<NJobType>> GetAsync(List<Guid> ids);
    }
}
