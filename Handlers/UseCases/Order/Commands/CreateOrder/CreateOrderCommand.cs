using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationServices.Interfaces;

namespace Handlers.UseCases.Order.Commands.CreateOrder
{
    public class CreateOrderCommand
    {
        public ChangeOrderDto Dto { get; set; }
    }
}