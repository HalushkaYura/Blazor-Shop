using FluentValidation;
using MintStores.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintStores.Infrastructure.Validations
{
    public class OrderItemsValidator : AbstractValidator<OrderItem>
    {
        public OrderItemsValidator()
        {
            RuleFor(orderItem => orderItem.Quantity)
                .GreaterThan(0).WithMessage("Кількість має бути більше 0.");

            RuleFor(orderItem => orderItem.Price)
                .GreaterThan(0).WithMessage("Ціна має бути більше 0.");
        }
    }
}
