using FluentValidation;
using MintStores.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintStores.Infrastructure.Validations
{
    public class BrandsValidator : AbstractValidator<Brand>
    {
        public BrandsValidator()
        {
            RuleFor(brand => brand.BrandName)
                .NotEmpty().WithMessage("Поле BrandName не може бути порожнім.")
                .MaximumLength(100).WithMessage("Максимальна довжина BrandName - 100 символів.");
        }
    }
}
