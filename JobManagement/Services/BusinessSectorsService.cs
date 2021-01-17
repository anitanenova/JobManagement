namespace JobManagement.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models.Nomenclatures;

    public class BusinessSectorsService : IBusinessSectorsService
    {
        private readonly JobManagementDbContext _context;

        public BusinessSectorsService(JobManagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<NBusinessSector>> GetPageAsync(int skip, int take)
        {
            var businessSectors = await _context.NBusinessSectors.OrderBy(x => x.Position).Skip(skip).Take(take).ToListAsync();
            return businessSectors;
        }

        public async Task<NBusinessSector> GetAsync (Guid id)
        {
            var businessSector = await _context.NBusinessSectors.FindAsync(id);
            return businessSector;
        }
    }
}
