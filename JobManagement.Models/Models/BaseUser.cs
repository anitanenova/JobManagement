namespace JobManagement.Models.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Enums;
    using Microsoft.AspNetCore.Identity;
    using Nomenclatures;

    public abstract class BaseUser: IdentityUser<Guid>
    {
        public UserTypeEnum UserType { get; private set; }
    }
}