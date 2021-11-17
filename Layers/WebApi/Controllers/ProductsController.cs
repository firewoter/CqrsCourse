using ApplicationServices.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public Task<ProductDto> GetByIdAsync(int id, [FromServices] IReadOnlyProductService readOnlyProductService)
        {
            return readOnlyProductService.GetByIdAsync(id);
        }

        [HttpPost]
        public Task<int> CreateAsync([FromBody] ChangeProductDto dto)
        {
            return _productService.CreateAsync(dto);
        }

        [HttpPut("{id}")]
        public Task UpdateAsync(int id, [FromBody] ChangeProductDto dto)
        {
            return _productService.UpdateAsync(id, dto);
        }
    }
}