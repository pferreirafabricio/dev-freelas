using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace DevFreela.Application.Queries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserViewModel>
    {
        private readonly string _connectionString;

        public GetUserQueryHandler(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DevFreelaCs");
        }

        public async Task<UserViewModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            using (var sqlConnection = new MySqlConnection(_connectionString))
            {
                sqlConnection.Open();

                var script = "SELECT FullName, Email from users WHERE Id = @id";

                var dbResut = await sqlConnection
                    .QueryAsync<UserViewModel>(script, new { request.Id });

                return dbResut.ToList().SingleOrDefault();
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