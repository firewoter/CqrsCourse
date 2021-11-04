﻿using System.Threading.Tasks;
using ApplicationServices.Interfaces;
using AutoMapper;
using Entities;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApplicationServices.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ICurrentUserService _currentUserService;

        public OrderService(IDbContext dbContext, IMapper mapper, ICurrentUserService currentUserService)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _currentUserService = currentUserService;
        }

        public async Task<int> CreateAsync(ChangeOrderDto dto)
        {
            var order = _mapper.Map<Order>(dto);
            order.UserEmail = _currentUserService.Email;
            _dbContext.Orders.Add(order);
            await _dbContext.SaveChangesAsync();
            return order.Id;
        }

        public async Task UpdateAsync(int id, ChangeOrderDto dto)
        {
            var order = await _dbContext.Orders
                .Include(x => x.Items)
                .SingleAsync(x => x.Id == id);
            _mapper.Map(dto, order);
            await _dbContext.SaveChangesAsync();
        }
    }
}