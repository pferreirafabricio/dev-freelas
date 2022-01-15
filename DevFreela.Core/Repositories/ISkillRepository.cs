using System.Collections.Generic;
using System.Threading.Tasks;
using DevFreela.Core.DTOs;
using DevFreela.Core.Entities;

namespace DevFreela.Core.Repositories
{   
    public interface ISkillRepository
    {
        Task<List<SkillDTO>> GetAllAsync();
    }
}
