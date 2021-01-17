namespace JobManagement.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models.Models;
    using Models.Nomenclatures;

    public interface IGalleryService
    {
        Task<List<GalleryImage>> GetAsync(int skip, int take);
    }
}