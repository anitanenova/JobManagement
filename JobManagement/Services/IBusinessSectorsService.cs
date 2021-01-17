
namespace JobManagement.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models.Nomenclatures;

    public interface IBusinessSectorsService
    {
        Task<List<NBusinessSector>> GetPageAsync(int skip, int take);

        Task<NBusinessSector> GetAsync(Guid id);
    }
}
