using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).NotNull();
            RuleFor(u => u.Email).MaximumLength(50);
            RuleFor(u => u.Email).Must(MailCheck).When(u => u.Email != null).WithMessage("Mail address contains '@'.");
            RuleFor(u => u.FirstName).NotNull();
            RuleFor(u => u.FirstName).MaximumLength(15);
            RuleFor(u => u.LastName).NotNull();
            RuleFor(u => u.LastName).MaximumLength(15);
            RuleFor(u => u.Password).NotNull();
            RuleFor(u => u.Password).MaximumLength(20);
        }

        private bool MailCheck(string arg)
        {
            return arg.Contains("@");
        }
    }
}
