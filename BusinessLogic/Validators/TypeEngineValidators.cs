using Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Validators
{
    public class TypeEngineValidators : AbstractValidator<TypeEngineDto>
    {
        public TypeEngineValidators()
        {
            RuleFor(te => te.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2);

            RuleFor(te => te.Description)
                .NotEmpty()
                .NotNull()
                .MinimumLength(2);
        }
    }
}
