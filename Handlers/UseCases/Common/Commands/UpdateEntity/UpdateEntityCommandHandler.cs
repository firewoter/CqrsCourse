using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entities;
using Handlers.CqrsFramework;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Handlers.UseCases.Common.Commands.UpdateEntity
{
    public abstract class UpdateEntityCommandHandler<TRequest, TEntity, TDto> : RequestHandler<TRequest>
        where TEntity : Entity
        where TRequest : UpdateEntityCommand<TDto>
    {
        protected readonly IDbContext DbContext;
        private readonly IMapper _mapper;

        protected UpdateEntityCommandHandler(IDbContext dbContext, IMapper mapper)
        {
            DbContext = dbContext;
            _mapper = mapper;
        }

        protected override async Task HandleAsync(TRequest request)
        {
            object entity = await GetTrackedEntityAsync(request.Id);
            _mapper.Map(request.Dto, entity);
            await DbContext.SaveChangesAsync();
        }

        protected virtual async Task<object> GetTrackedEntityAsync(int id)
        {
            return await DbContext.Set<TEntity>().FindAsync(id);
        }
    }
}