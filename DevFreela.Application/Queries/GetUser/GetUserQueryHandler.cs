using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Repositories;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace DevFreela.Application.Queries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserViewModel>
    {
        private readonly IUserRepository _userRepository;

        public GetUserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserViewModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(request.Id);

            if (user == null)
                return null;

            var userViewModel = new UserViewModel(user.FullName, user.Email);

            return userViewModel;

            // var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            // if (user == null)
            // {
            //     return null;
            // }

            // return new UserViewModel(user.FullName, user.Email);
        }
    }
}