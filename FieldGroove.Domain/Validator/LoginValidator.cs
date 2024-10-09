using FieldGroove.Domain.Models;
using FluentValidation;

namespace FieldGroove.Domain.Validator;

public class LoginValidator : AbstractValidator<LoginModel>
{
    public LoginValidator()
    {
        RuleFor(log => log.Email)
            .EmailAddress().WithMessage("Enter the valid Email")
            .NotEmpty().WithMessage("Email is requried")
            .Matches(@"^[a-zA-Z0-9._%+-]+@gmail\.com$").WithMessage("This Email is not Allowed.");

        RuleFor(log => log.Password)
            .NotEmpty().WithMessage("Password is required")
            .Length(8, 40).WithMessage("password must be between 8 and 40 characters.")
            .Matches(@"^[a-zA-Z0-9._+%\-!@#$^&*()]+$").WithMessage("Password must be Strong pattern");
    }
}

