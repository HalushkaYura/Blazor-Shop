using FluentValidation;
using MintStores.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintStores.Infrastructure.Validations
{
    public class CategoriesValidator : AbstractValidator<Category>
    {
        public CategoriesValidator()
        {
            RuleFor(category => category.CategoryName)
                .NotEmpty().WithMessage("Поле CategoryName не може бути порожнім.")
                .MaximumLength(100).WithMessage("Максимальна довжина CategoryName - 100 символів.");
        }
    }
}
