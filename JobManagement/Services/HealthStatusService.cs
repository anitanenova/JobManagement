namespace JobManagement.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models.Nomenclatures;

    public class HealthStatusService : IHealthStatusService
    {
        private readonly JobManagementDbContext _context;

        public HealthStatusService(JobManagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<NHealthStatus>> GetPageAsync(int skip, int take)
        {
            var healthStatus = await _context.NHealthStatuses.OrderBy(x => x.Position).Skip(skip).Take(take).ToListAsync();
            return healthStatus;
        }


        public async Task<List<NHealthStatus>> GetAsync(List<Guid> ids)
        {
            var healthStatus = await _context.NHealthStatuses.OrderBy(x => x.Position).Where(t => ids.Contains(t.Id)).ToListAsync();
            return healthStatus;
        }
    }
}