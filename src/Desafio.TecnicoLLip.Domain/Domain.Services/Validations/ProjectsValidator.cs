#region Includes
using Desafio.TecnicoLLip.Domain.Models;
using Desafio.TecnicoLLip.Domain.Validations;
using FluentValidation;
#endregion

namespace Desafio.TecnicoLLip.Domain.Services.Validations
{
    public class ProjectsValidator : AbstractValidator<Projects>
    {
        public ProjectsValidator()
        {
            RuleFor(x => x.Title)
                 .IsRequired();

            RuleFor(x => x.Description)
                .IsRequired();

            RuleFor(x => x.CreationDate)
                .NotNull();
        }
    }
}