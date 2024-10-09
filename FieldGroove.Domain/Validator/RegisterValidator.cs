using FieldGroove.Domain.Models;
using FluentValidation;

namespace FieldGroove.Domain.Validator
{
    public class RegisterValidator : AbstractValidator<RegisterModel>
    {
        public RegisterValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty().WithMessage("First Name is required.")
                .MinimumLength(2).WithMessage("First Name must be at least 2 characters long.");

            RuleFor(x => x.LastName)
                .NotEmpty().WithMessage("Last Name is required.")
                .MinimumLength(1).WithMessage("Last Name must be at least 1 characters long.");

            RuleFor(x => x.CompanyName)
                .MinimumLength(2).When(x => !string.IsNullOrEmpty(x.CompanyName)).WithMessage("Company Name must be at least 2 characters long.");

            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Phone number is required.")
                .InclusiveBetween(1000000000, 9999999999).WithMessage("Phone number must be 10 digits long.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Email is required.")
                .Matches(@"^[a-zA-Z0-9._%+-]+@gmail\.com$").WithMessage("Only gmail.com email addresses are allowed.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password is required.")
                .MinimumLength(6).WithMessage("Password must be at least 6 characters long.");

            RuleFor(x => x.PasswordAgain)
                .Equal(x => x.Password).WithMessage("Passwords must match.");

            RuleFor(x => x.TimeZone)
                .NotEmpty().WithMessage("TimeZone is required.");

            RuleFor(x => x.StreetAddress1)
                .NotEmpty().WithMessage("Street Address 1 is required.");

            RuleFor(x => x.StreetAddress2)
                .MaximumLength(100).WithMessage("Street Address 2 must be less than 100 characters.");

            RuleFor(x => x.City)
                .NotEmpty().WithMessage("City is required.")
                .MaximumLength(50).WithMessage("City must be less than 50 characters.");

            RuleFor(x => x.State)
                .NotEmpty().WithMessage("State is required.")
                .MaximumLength(50).WithMessage("State must be less than 50 characters.");

            RuleFor(x => x.Zip)
              .NotEmpty().WithMessage("Invalid Zip Code.");

        }
    }
}
