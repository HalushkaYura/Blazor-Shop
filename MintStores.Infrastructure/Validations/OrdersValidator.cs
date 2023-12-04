using FluentValidation;
using MintStores.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MintStores.Infrastructure.Validations
{
    public class OrdersValidator : AbstractValidator<Order>
    {
        public OrdersValidator()
        {
            RuleFor(order => order.OrderStatus)
                .IsInEnum().WithMessage("Неприпустимий статус замовлення.");

            RuleFor(order => order.OrderDate)
                .NotEmpty().WithMessage("Поле OrderDate не може бути порожнім.");
        }
    }
}
