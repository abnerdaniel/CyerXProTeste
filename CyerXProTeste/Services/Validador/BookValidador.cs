using CyerXProTeste.Models;
using FluentValidation;

namespace CyerXProTeste.Services.Validador
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(b => b.Title).NotEmpty().WithMessage("Title is required.");
            //RuleFor(b => b.Id).NotEmpty().WithMessage("Author is required.");
        }
    }

}
