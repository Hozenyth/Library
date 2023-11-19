using FluentValidation;
using Library.Api.Models;

namespace Library.Api.Validators
{
    public class CreaterBookValidator : AbstractValidator<CreateBookModel>
    {
        public CreaterBookValidator()
        {
            RuleFor(c => c.Author)
                .NotEmpty().WithMessage("the Author is required")
                .MaximumLength(100).WithMessage("The book Author must have maximum of 100 characters");

            RuleFor(c => c.Title)
                .NotEmpty().WithMessage("the Title is required")
                .MaximumLength(100).WithMessage("The Title must have maximum of 100 characters");

            RuleFor(c => c.Isbn)
                .NotEmpty().WithMessage("the Isbn is required")
                .MaximumLength(20).WithMessage("The Isbn must have maximum of 20 characters");
        }
    }
}
