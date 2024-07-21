using CyerXProTeste.Models;
using FluentValidation;


namespace CyerXProTeste.Services.Validador
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(a => a.Name).NotEmpty().WithMessage("Name is required.");
        }
    }
}
