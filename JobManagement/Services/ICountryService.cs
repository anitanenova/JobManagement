namespace JobManagement.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models.Nomenclatures;

    public interface ICountryService
    {
        Task<List<NCountry>> GetPageAsync(int skip, int take);
    }
}