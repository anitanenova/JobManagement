namespace JobManagement.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Models.Nomenclatures;

    public interface ISkillService
    {
        Task<List<NSkill>> GetPageAsync(int skip, int take);
        Task<List<NSkill>> GetAsync(List<Guid> ids);
    }
}