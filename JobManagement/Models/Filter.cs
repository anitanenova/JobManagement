namespace JobManagement.Models
{
    using System;

    public class Filter
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; }
    }
}