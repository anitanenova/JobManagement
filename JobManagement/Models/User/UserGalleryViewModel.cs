namespace JobManagement.Models.User
{
    using Microsoft.AspNetCore.Http;
    using Models;
    using System.Collections.Generic;
    public class UserGalleryViewModel
    {
        public List<GalleryImage> GalleryImages { get; set; }
    }
}
