using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Core.DTOs;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Infrastructure.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private readonly DevFreelaDbContext _dbContext;

        public SkillRepository(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<SkillDTO>> GetAllAsync()
        {
            return await _dbContext.Skills
                .Select(s => new SkillDTO(s.Id, s.Description))
                .ToListAsync();
        }
    }
}