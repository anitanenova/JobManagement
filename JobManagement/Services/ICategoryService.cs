namespace JobManagement.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models.Nomenclatures;

    public interface ICategoryService
    {
        Task<List<NCategory>> GetPageAsync(int skip, int take);
        Task<List<NCategory>> GetAsync(List<Guid> ids);
    }
}