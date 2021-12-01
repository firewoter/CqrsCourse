using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationServices.Interfaces;
using AutoMapper;
using Handlers.CqrsFramework;
using Infrastructure.Interfaces;
using Handlers.UseCases.Common.Commands.CreateEntity;

namespace Handlers.UseCases.Order.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : CreateEntityCommandHandler<CreateOrderCommand, Entities.Order, ChangeOrderDto>
    {
        private readonly ICurrentUserService _currentUserService;

        public CreateOrderCommandHandler(IDbContext dbContext, IMapper mapper, ICurrentUserService currentUserService)
            : base(dbContext, mapper)
        {
            _currentUserService = currentUserService;
        }

        public override async Task<int> HandleAsync(CreateOrderCommand request)
        {
            // do something additional, i.e. statistics 
            return await base.HandleAsync(request);
        }

        protected override void InitializeNewEntity(Entities.Order entity)
        {
            entity.UserEmail = _currentUserService.Email;
        }
    }
}