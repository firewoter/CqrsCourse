using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationServices.Interfaces;
using Handlers.UseCases.Common.Commands.UpdateEntity;

namespace Handlers.UseCases.Order.Commands.UpdateOrder
{
    public class UpdateOrderCommand : UpdateEntityCommand<ChangeOrderDto>
    {
        public int Id { get; set; }
        public ChangeOrderDto Dto { get; set; }
    }
}