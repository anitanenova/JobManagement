namespace JobManagement.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models.Nomenclatures;

    public class CountryService : ICountryService
    {
        private readonly JobManagementDbContext _context;

        public CountryService(JobManagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<NCountry>> GetPageAsync(int skip, int take)
        {
            var countries = await _context.NCountries.OrderBy(x => x.Position).Skip(skip).Take(take).ToListAsync();
            return countries;
        }

    }
}