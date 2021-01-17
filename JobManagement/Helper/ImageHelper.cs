namespace JobManagement.Helper
{
    using System;
    using System.IO;
    using Factories;
    using Microsoft.AspNetCore.Http;

   public static class ImageHelper 
    {
        public static string ImageToBase64(IFormFile file)
        {
            using (var ms = new MemoryStream())
            {
                file.CopyTo(ms);
                var fileBytes = ms.ToArray();
                return Convert.ToBase64String(fileBytes);

            }
        }
    }
}
