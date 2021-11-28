using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x=>x.BlogTitle).NotEmpty().WithMessage("Blog Title can't be empty!!").
                MaximumLength(40).WithMessage("Blog Title can't be more than 40 char!!").MinimumLength(4).WithMessage("Blog Title must be more 4 char!!");
            RuleFor(x=>x.BlogContent).MinimumLength(10).WithMessage("Content must more 10 char!!").NotEmpty().WithMessage("Blog Content can't be empty!!");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog Image can't be empty!!");
        }
    }
}
