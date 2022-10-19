using FluentValidation;
using MasVeterinarias.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasVeterinarias.Infraestructure.Validators
{
    public  class TagValidator : AbstractValidator<TagRequestDto>
    {
        public TagValidator()
        {
           
            RuleFor(tag => tag.Name)
               .NotNull()
               .Length(3, 50);
        }
    }
}
