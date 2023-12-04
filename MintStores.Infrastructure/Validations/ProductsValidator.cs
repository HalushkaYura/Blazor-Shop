using FluentValidation;
using MintStores.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintStores.Infrastructure.Validations
{
    public class ProductsValidator : AbstractValidator<Product>
    {
        public ProductsValidator()
        {
            RuleFor(product => product.ProductName)
                .NotEmpty().WithMessage("Поле ProductName не може бути порожнім.")
                .MaximumLength(100).WithMessage("Максимальна довжина ProductName - 100 символів.");

            RuleFor(product => product.ModelYear)
               .NotEmpty().WithMessage("Поле ModelYear не може бути порожнім.")
               .GreaterThan((short)0).WithMessage("Years must be greater than 0");

            RuleFor(product => product.Price)
                .NotEmpty().WithMessage("Поле Price не може бути порожнім.")
                .GreaterThan(0).WithMessage("Ціна має бути більше 0.");
        }
    }
}
