using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p=>p.ProductName).NotEmpety();
            RuleFor(p=>p.ProductName).MinimumLenght(2);
            RuleFor(p=>p.UnıtPrice).NotEmpety();
            RuleFor(p=>p.UnıtPrice).GreaterThan(0);
            RuleFor(p => p.UnıtPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId==1);
            RuleFor(p => p.ProductName).Must(StartWithA);
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");
        }

        private bool StartWithA(object arg)
        {
            return arg.StartWith("A");
        }
    }
}
