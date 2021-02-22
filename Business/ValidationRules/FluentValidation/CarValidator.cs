using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator: AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.ModelYear).GreaterThan(0);
            RuleFor(c => c.ModelYear).LessThan(DateTime.Now.Year);
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).NotEqual(0);
            RuleFor(c => c.BrandId).NotNull();
            RuleFor(c => c.BrandId).GreaterThan(0);
            RuleFor(c => c.ColorId).NotNull();
            RuleFor(c => c.ColorId).GreaterThan(0);
            RuleFor(c => c.Description).MaximumLength(100);
        }
    }
}
