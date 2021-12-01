using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationServices.Interfaces;

namespace Handlers.UseCases.Common.Commands.UpdateEntity
{
    public abstract class UpdateEntityCommand<TDto>
    {
        public int Id { get; set; }
        public TDto Dto { get; set; }
    }
}