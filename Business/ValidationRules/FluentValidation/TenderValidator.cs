using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class TenderValidator : AbstractValidator<Tender>
    {
        public TenderValidator()
        {
            RuleFor(t=>t.TenderTitle).MaximumLength(50);
            RuleFor(t => t.StartDate).MaximumLength(15);
            RuleFor(t => t.EndDate).MaximumLength(15);
        }
    }
}
