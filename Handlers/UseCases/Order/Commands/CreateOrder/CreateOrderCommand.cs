using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationServices.Interfaces;
using Handlers.UseCases.Common.Commands.CreateEntity;

namespace Handlers.UseCases.Order.Commands.CreateOrder
{
    public class CreateOrderCommand : CreateEntityCommand<ChangeOrderDto>
    {
    }
}