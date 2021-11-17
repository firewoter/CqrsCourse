using ApplicationServices.Interfaces;
using AutoMapper;
using Entities;
using Infrastructure.Interfaces;

namespace ApplicationServices.Implementation
{
    public class ReadOnlyProductService : ReadOnlyEntityService<Product, ProductDto>, IReadOnlyProductService
    {
        public ReadOnlyProductService(
            IReadOnlyDbContext dbContext,
            IMapper mapper)
            : base(dbContext, mapper)
        {
        }
    }
}