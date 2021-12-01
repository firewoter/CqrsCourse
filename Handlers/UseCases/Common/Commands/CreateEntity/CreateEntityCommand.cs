using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationServices.Interfaces;

namespace Handlers.UseCases.Common.Commands.CreateEntity
{
    public abstract class CreateEntityCommand<TDto>
    {
        public TDto Dto { get; set; }
    }
}