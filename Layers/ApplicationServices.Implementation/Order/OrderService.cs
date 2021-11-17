using System.Threading.Tasks;
using ApplicationServices.Interfaces;
using AutoMapper;
using Entities;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApplicationServices.Implementation
{
    public class OrderService : EntityService<Order, ChangeOrderDto>, IOrderService
    {
        private readonly ICurrentUserService _currentUserService;

        public OrderService(
            IDbContext dbContext,
            IMapper mapper,
            ICurrentUserService currentUserService) : base(dbContext, mapper)
        {
            _currentUserService = currentUserService;
        }

        protected override void InitializeNewEntity(Order entity)
        {
            entity.UserEmail = _currentUserService.Email;
        }

        protected override async Task<Entity> GetTrackedEntityAsync(int id)
        {
            return await DbContext.Orders
                .Include(x => x.Items)
                .SingleAsync(x => x.Id == id);
        }
    }
}