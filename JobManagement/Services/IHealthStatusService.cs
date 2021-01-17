namespace JobManagement.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models.Nomenclatures;

    public interface IHealthStatusService 
    {
        Task<List<NHealthStatus>> GetPageAsync(int skip, int take);
        Task<List<NHealthStatus>> GetAsync(List<Guid> ids);
    }
}