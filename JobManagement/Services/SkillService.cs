namespace JobManagement.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models.Nomenclatures;

    public class SkillService : ISkillService
    {
        private readonly JobManagementDbContext _context;

        public SkillService(JobManagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<NSkill>> GetPageAsync(int skip, int take)
        {
            var skills = await _context.NSkills.OrderBy(x => x.Position).Skip(skip).Take(take).ToListAsync();
            return skills;
        }


        public async Task<List<NSkill>> GetAsync(List<Guid> ids)
        {
            var skills = await _context.NSkills.OrderBy(x => x.Position).Where(t => ids.Contains(t.Id)).ToListAsync();
            return skills;
        }
    }
}