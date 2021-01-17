namespace JobManagement.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models.Models;
    using Models.Nomenclatures;

    public class GalleryService : IGalleryService
    {
        private readonly JobManagementDbContext _context;

        public GalleryService(JobManagementDbContext context)
        {
            _context = context;
        }

        public async Task<List<GalleryImage>> GetAsync(int skip, int take)
        {
            var galleryImages = await _context.GalleryImages.OrderBy(x => x.Id).Skip(skip).Take(take).ToListAsync();
            return galleryImages;
        }
    }
}