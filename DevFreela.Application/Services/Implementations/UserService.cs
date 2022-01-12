using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using DevFreela.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using System.Linq;
using Dapper;
using MySqlConnector;

namespace DevFreela.Application.Services.Implementations
{
    public class UserService : IUserService
    {
        private readonly DevFreelaDbContext _dbContext;
        private readonly string _connectionString;

        public UserService(DevFreelaDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _connectionString = configuration.GetConnectionString("DevFreelaCs");
        }

        public UserViewModel GetUser(int id)
        {
            using (var sqlConnection = new MySqlConnection(_connectionString))
            {
                sqlConnection.Open();

                var script = "SELECT FullName, Email from users WHERE Id = @id";

                return sqlConnection
                    .Query<UserViewModel>(script, new { id })
                    .SingleOrDefault();
            }

            // var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            // if (user == null)
            // {
            //     return null;
            // }

            // return new UserViewModel(user.FullName, user.Email);
        }
    }
}
