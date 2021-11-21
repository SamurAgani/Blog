using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WritersValidations : AbstractValidator<Writer>
    {
        public WritersValidations()
        {
            RuleFor(x => x.WriterName).NotEmpty().MinimumLength(3).WithMessage("Not less than 3!");
            RuleFor(x => x.WriterName).NotEmpty().MaximumLength(25).WithMessage("Not much than 25!");
            RuleFor(x => x.WriterMail).NotEmpty().EmailAddress().MinimumLength(6).WithMessage("Not less than 6!");
            RuleFor(x => x.WriterPassword).NotEmpty().MinimumLength(6).WithMessage("Not less than 6!");
            RuleFor(p => p.WriterPassword).NotEmpty().Matches(@"[A-Z]+").WithMessage("Your password must contain at least one uppercase letter.");
            RuleFor(p => p.WriterPassword).NotEmpty().Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter.");
            RuleFor(p => p.WriterPassword).NotEmpty().Matches(@"[0-9]+").WithMessage("Your password must contain at least one number.");
            RuleFor(x => x.WriterPassword).NotEmpty().Matches(@"[\!\?\*\.]*$").WithMessage("Your password must contain at least one (!? *.).");
        }
    }
}
