using FluentValidation;
using Manager.Domain.Entities;

namespace Manager.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x)
            .NotEmpty()
            .WithMessage("A Entidade não pode ser vazia.")

            .NotNull()
            .WithMessage("A entidae mão pode ser  nula.");

            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage("O nome nao pode ser nulo.")

                .NotEmpty()
                .WithMessage("O nome nao pode ser vazio")

                .MinimumLength(3)
                .WithMessage("O nome deve ter no minimo 3 caracteres")

                .MaximumLength(80)
                .WithMessage("O nome deve ter no maximo 8 caracteres");

            RuleFor(x => x.Email)
               .NotNull()
               .WithMessage("O email nao pode ser nulo.")

               .NotEmpty()
               .WithMessage("O email nao pode ser vazio")

               .MinimumLength(7)
               .WithMessage("O email deve ter no minimo 7 caracteres")

               .MaximumLength(180)
               .WithMessage("O email deve ter no maximo 180 caracteres")

               .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
               .WithMessage("O email informado não é valido");

            RuleFor(x => x.Password)
                .NotNull()
                .WithMessage("A senha nao pode ser nulo.")

                .NotEmpty()
                .WithMessage("A senha  nao pode ser vazio")

                .MinimumLength(6)
                .WithMessage("A senha  deve ter no minimo 6 caracteres")

                .MaximumLength(80)
                .WithMessage("A senha  deve ter no maximo 80 caracteres");

        }
    }
}
