using FluentValidation;
using MintStores.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintStores.Infrastructure.Validations
{
    public class StoresValidator : AbstractValidator<Store>
    {
        public StoresValidator()
        {
            RuleFor(store => store.StoreName)
                .NotEmpty().WithMessage("Поле StoreName не може бути порожнім.")
                .MaximumLength(100).WithMessage("Максимальна довжина StoreName - 100 символів.");
        }
    }
}
