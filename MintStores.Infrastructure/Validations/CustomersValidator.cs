using FluentValidation;
using MintStores.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintStores.Infrastructure.Validations
{
    public class CustomersValidator : AbstractValidator<Customer>
    {
        public CustomersValidator()
        {
            RuleFor(customer => customer.FirstName)
                .NotEmpty().WithMessage("Поле FirstName не може бути порожнім.")
                .MaximumLength(100).WithMessage("Максимальна довжина FirstName - 100 символів.");

            RuleFor(customer => customer.LastName)
                .NotEmpty().WithMessage("Поле LastName не може бути порожнім.")
                .MaximumLength(100).WithMessage("Максимальна довжина LastName - 100 символів.");

            RuleFor(customer => customer.Email)
                .NotEmpty().WithMessage("Поле Email не може бути порожнім.")
                .MaximumLength(100).WithMessage("Максимальна довжина Email - 100 символів.")
                .EmailAddress().WithMessage("Введіть коректну адресу електронної пошти.");
        }
    }
}
