using System.Collections.Generic;
using System.Threading.Tasks;
using DevFreela.Core.DTOs;
using DevFreela.Core.Entities;

namespace DevFreela.Core.Repositories
{   
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);
        Task<User> GetByEmailAndPasswordAsync(string email, string passwordHash);
        Task AddAsync(User user);
    }
}
