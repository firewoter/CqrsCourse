﻿using ApplicationServices.Interfaces;
using AutoMapper;
using Entities;

namespace ApplicationServices.Implementation
{
    public class OrderMapperProfile : Profile
    {
        public OrderMapperProfile()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<OrderItem, OrderItemDto>().ReverseMap();
            CreateMap<ChangeOrderDto, Order>();
        }
    }
}