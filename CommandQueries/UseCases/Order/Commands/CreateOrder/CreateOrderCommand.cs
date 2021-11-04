using ApplicationServices.Interfaces;

namespace CQ.UseCases.Order.Commands.CreateOrder
{
    public class CreateOrderCommand
    {
        public ChangeOrderDto Dto { get; set; }
        public int Id { get; set; }
    }
}