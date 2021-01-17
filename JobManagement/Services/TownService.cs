namespace JobManagement.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models.Nomenclatures;

    public class TownService : ITownService
    {
        private readonly JobManagementDbContext _context;

        public TownService(JobManagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<NTown>> GetPageAsync(int skip, int take)
        {
            var towns = await _context.NTowns.OrderBy(x => x.Position).Skip(skip).Take(take).ToListAsync();
            return towns;
        }

    }
}