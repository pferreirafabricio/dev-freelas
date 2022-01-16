using DevFreela.Application.ViewModels;
using MediatR;

namespace DevFreela.Application.Commands.LoginUser
{
    public class LoginUserCommand : IRequest<LoginUserViwModel>
    {
        public string Email { get; set; }   
        
        public string Password { get; set; }
    }
}