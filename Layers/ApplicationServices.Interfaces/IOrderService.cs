using System.Threading.Tasks;

namespace ApplicationServices.Interfaces
{
    public interface IOrderService
    {
        Task<int> CreateAsync(ChangeOrderDto dto);

        Task UpdateAsync(int id, ChangeOrderDto dto);
    }
}