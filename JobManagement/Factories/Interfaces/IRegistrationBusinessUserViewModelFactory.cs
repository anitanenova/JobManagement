﻿namespace JobManagement.Factories.Interfaces
{
    using System.Threading.Tasks;
    using Models.Account;

    public interface IRegistrationBusinessUserViewModelFactory
    {
        Task<RegistrationBusinessUserViewModel> CreateAsync();
    }
}