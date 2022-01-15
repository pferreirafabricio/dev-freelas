using System.Text.RegularExpressions;
using DevFreela.Application.Commands.CreateUser;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(p => p.Email)
                .EmailAddress()
                .WithMessage("E-mail não é válido");

            RuleFor(p => p.Password)
                .Must(ValidPassword)
                .WithMessage("Senha não é válido");

            RuleFor(p => p.FullName)
                .NotEmpty()
                .NotNull()
                .WithMessage("Nome é obrigatório");
        }

        public bool ValidPassword(string password)
        {
            var regex = new Regex("/i");

            return regex.IsMatch(password);
        }
    }
}