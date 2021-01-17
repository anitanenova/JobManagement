namespace JobManagement.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models.Nomenclatures;

    public interface IEducationsService
    {
        Task<List<NEducation>> GetPageAsync(int skip, int take);
    }
}