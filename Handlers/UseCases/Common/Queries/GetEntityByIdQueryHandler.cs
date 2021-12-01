using AutoMapper;
using AutoMapper.QueryableExtensions;
using Handlers.CqrsFramework;
using Entities;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Handlers.UseCases.Common.Queries
{
    public abstract class GetEntityByIdQueryHandler<TRequest, TEntity, TDto> : IRequestHandler<TRequest, TDto>
        where TEntity : Entity
        where TRequest : GetEntityByIdQuery
    {
        private readonly IReadOnlyDbContext _dbContext;
        private readonly IMapper _mapper;

        protected GetEntityByIdQueryHandler(IReadOnlyDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public virtual async Task<TDto> HandleAsync(TRequest request)
        {
            var result = await _dbContext.Set<TEntity>()
                .Where(o => o.Id == request.Id)
                .ProjectTo<TDto>(_mapper.ConfigurationProvider)
                .SingleAsync();

            return result;
        }
    }
}
