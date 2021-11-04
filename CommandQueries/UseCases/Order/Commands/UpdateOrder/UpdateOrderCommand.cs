using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationServices.Interfaces;

namespace CQ.UseCases.Order.Commands.UpdateOrder
{
    public class UpdateOrderCommand
    {
        public int Id { get; set; }
        public ChangeOrderDto Dto { get; set; }
    }
}