using FluentValidation;

namespace PostCleanArchitecture.Application.Features.Posts.Commands.CreatePost
{
    // to use this install FluentValidation.DependencyInjectionExtensions
    public class CreateCommandValidator : AbstractValidator<CreatePostCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100);

            RuleFor(p => p.Content)
                .NotEmpty()
                .NotNull();
        }
    }
}
