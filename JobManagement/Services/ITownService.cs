namespace JobManagement.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models.Nomenclatures;

    public interface ITownService
    {
        Task<List<NTown>> GetPageAsync(int skip, int take);
    }
}