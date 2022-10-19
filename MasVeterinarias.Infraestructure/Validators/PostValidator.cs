using FluentValidation;
using MasVeterinarias.Domain.DTOs;

namespace MasVeterinarias.Infraestructure.Validators
{
    public  class PostValidator : AbstractValidator<PostRequestDto>
    {
        public PostValidator()
        {
            RuleFor(post => post.Title)
                .NotNull()
                .Length(3, 75);
            RuleFor(post => post.Filename)
                .NotNull()
                .Length(3, 75);
           
        }

    }
}
