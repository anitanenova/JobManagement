namespace JobManagement.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models.Nomenclatures;

    public interface IGenderService
    {
        Task<List<NGender>> GetPageAsync(int skip, int take);
    }
}