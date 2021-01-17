namespace JobManagement.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models.Nomenclatures;

    public class CategoryService : ICategoryService
    {
        private readonly JobManagementDbContext _context;

        public CategoryService(JobManagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<NCategory>> GetPageAsync(int skip, int take)
        {
            var categories = await _context.NCategories.OrderBy(x => x.Position).Skip(skip).Take(take).ToListAsync();
            return categories;
        }


        public async Task<List<NCategory>> GetAsync(List<Guid> ids)
        {
            var categories = await _context.NCategories.OrderBy(x => x.Position).Where(t => ids.Contains(t.Id)).ToListAsync();
            return categories;
        }
    }
}