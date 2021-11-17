using System.Threading.Tasks;

namespace ApplicationServices.Interfaces
{
    public interface IReadOnlyProductService : IReadOnlyEntityService<ProductDto>
    {
    }
}