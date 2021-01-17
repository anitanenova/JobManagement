namespace JobManagement.Services
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models.Nomenclatures;

    public class EducationsService : IEducationsService
    {
        private readonly JobManagementDbContext _context;

        public EducationsService(JobManagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<NEducation>> GetPageAsync(int skip, int take)
        {
            var educations = await _context.NEducations.OrderBy(x => x.Position).Skip(skip).Take(take).ToListAsync();
            return educations;
        }
    }
}