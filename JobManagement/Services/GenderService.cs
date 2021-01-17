namespace JobManagement.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models.Nomenclatures;

    public class GenderService : IGenderService
    {
        private readonly JobManagementDbContext _context;

        public GenderService(JobManagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<NGender>> GetPageAsync(int skip, int take)
        {
            var genders = await _context.NGenders.OrderBy(x => x.Position).Skip(skip).Take(take).ToListAsync();
            return genders;
        }

    }
}