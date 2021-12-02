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
            RuleFor(x => x.WriterName).NotEmpty().MinimumLength(3).WithMessage("Not less than 3!");
            RuleFor(x => x.WriterName).NotEmpty().MaximumLength(25).WithMessage("Not much than 25!");
            RuleFor(x => x.WriterMail).NotEmpty().EmailAddress().MinimumLength(6).WithMessage("Not less than 6!");
            RuleFor(x => x.WriterPassword).NotEmpty().MinimumLength(6).WithMessage("Not less than 6!");
        }
    }
}
