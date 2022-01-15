using System.Collections.Generic;
using System.Threading.Tasks;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Infrastructure.Repositories
{
    /// <summary>
    /// Tratar sempre entidades do domínio
    /// </summary>
    public class ProjectRepository : IProjectRepository
    {
        private readonly DevFreelaDbContext _dbContext;

        public ProjectRepository(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Project>> GetAllAsync()
        {
            return await _dbContext.Projects.ToListAsync();
        }

        public async Task<Project> GetByIdAsync(int id)
        {
            var project = await _dbContext.Projects
               .Include(x => x.Client) // Includes the object from another table
               .Include(x => x.Freelancer)
               .SingleOrDefaultAsync(p => p.Id == id);

            return project;
        }
    }
}