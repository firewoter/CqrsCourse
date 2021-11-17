using ApplicationServices.Interfaces;
using AutoMapper;
using Entities;
using Infrastructure.Interfaces;

namespace ApplicationServices.Implementation
{
    public class ProductService : EntityService<Product, ChangeProductDto>, IProductService
    {
        public ProductService(
            IDbContext dbContext,
            IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}