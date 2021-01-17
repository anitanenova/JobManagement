using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobManagement.Services
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models.Nomenclatures;

    public class JobTypeService : IJobTypeService
    {
        private readonly JobManagementDbContext _context;

        public JobTypeService(JobManagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<NJobType>> GetPageAsync(int skip, int take)
        {
            var jobTypes = await _context.NJobTypes.OrderBy(x => x.Position).Skip(skip).Take(take).ToListAsync();
            return jobTypes;
        }


        public async Task<List<NJobType>> GetAsync(List<Guid> ids)
        {
            var jobTypes = await _context.NJobTypes.OrderBy(x => x.Position).Where(t => ids.Contains(t.Id)).ToListAsync();
            return jobTypes;
        }
    }
}
