using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Not less than 3!");
            RuleFor(x => x.WriterName).MaximumLength(25).WithMessage("Not much than 25!");
            RuleFor(x => x.WriterMail).EmailAddress().MinimumLength(6).WithMessage("Not less than 6!");
            RuleFor(x => x.WriterPassword).MinimumLength(6).WithMessage("Not less than 6!");
            RuleFor(p => p.WriterPassword).Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.");
            RuleFor(p => p.WriterPassword).Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.");
            RuleFor(p => p.WriterPassword).Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.");
            RuleFor(x => x.WriterPassword).Matches(@"[\!\?\*\.]*$").WithMessage("Your password must contain at least one (!? *.).");
        }
    }
}
