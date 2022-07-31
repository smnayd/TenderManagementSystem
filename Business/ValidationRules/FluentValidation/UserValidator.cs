using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Email).MaximumLength(30);
            RuleFor(u => u.Username).NotEmpty();
            RuleFor(u => u.Username).MaximumLength(30);
            RuleFor(u => u.PasswordHash).NotNull();
            RuleFor(u => u.PAsswordSalt).NotNull();
            RuleFor(u => u.IdentityNumber).NotNull();

        }
    }
}
