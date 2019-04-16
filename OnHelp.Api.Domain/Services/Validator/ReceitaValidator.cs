using FluentValidation;
using OnHelp.Api.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnHelp.Api.Domain.Services.Validator
{
    public class ReceitaValidator : AbstractValidator<Receita>
    {
        public ReceitaValidator()
        {

            RuleFor(e => e.Description)
               .NotNull()
               .NotEmpty()
               .WithMessage("{PropertyName} da receita não pode ser nulo");

            RuleFor(e => e.Title)
               .NotNull()
               .NotEmpty()
               .WithMessage("{PropertyName} da receita não pode ser nulo");

            RuleFor(e => e.Ingredients)
              .NotNull()
              .NotEmpty()
              .WithMessage("Ingredientes da receita não pode ser nulo");

        }

    }
}
