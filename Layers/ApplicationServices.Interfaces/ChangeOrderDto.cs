using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationServices.Interfaces
{
    public class ChangeOrderDto
    {
        public List<OrderItemDto> Items { get; set; }
    }
}