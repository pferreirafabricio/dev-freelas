using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DevFreela.Core.DTOs;
using DevFreela.Core.Entities;
using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace DevFreela.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DevFreelaCs");
        }

        public async Task<User> GetByIdAsync(int id)
        {
            using (var sqlConnection = new MySqlConnection(_connectionString))
            {
                sqlConnection.Open();

                var script = "SELECT * from users WHERE Id = @id";

                var dbResut = await sqlConnection
                    .QueryAsync<User>(script, new { id });

                return dbResut.ToList().SingleOrDefault();
            }
        }
    }
}