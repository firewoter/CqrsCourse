using System.Threading.Tasks;
using CQ.CqrsFramework;
using Microsoft.AspNetCore.Mvc;
using ApplicationServices.Interfaces;
using CQ.UseCases.Order.Commands.CreateOrder;
using CQ.UseCases.Order.Commands.UpdateOrder;
using CQ.UseCases.Order.Queries.GetOrderById;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        [HttpGet("{id}")]
        public Task<OrderDto> GetByIdAsync(int id, [FromServices] IQueryHandler<GetOrderByIdQuery, OrderDto> getOrderByIdHandler)
        {
            return getOrderByIdHandler.HandleAsync(new GetOrderByIdQuery { Id = id });
        }

        [HttpPost]
        public async Task<int> CreateAsync([FromBody] ChangeOrderDto dto,
            [FromServices] ICommandHandler<CreateOrderCommand> handler)
        {
            var request = new CreateOrderCommand
            {
                Dto = dto
            };

            await handler.HandleAsync(request);

            return request.Id;
        }

        [HttpPut("{id}")]
        public Task UpdateAsync(int id, [FromBody] ChangeOrderDto dto, [FromServices] ICommandHandler<UpdateOrderCommand> handler)
        {
            return handler.HandleAsync(new UpdateOrderCommand { Id = id, Dto = dto });
        }
    }
}