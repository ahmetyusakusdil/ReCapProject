using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarValidator : AbstractValidator<Car>
    {
        
        public CarValidator()
        {

            RuleFor(c => c.ModelYear).GreaterThan(1985);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(3000).When(c => c.BrandId == 1);
            RuleFor(c => c.CarDescription).Length(15, 25).WithMessage("Description not range ");
        }
    }
}
