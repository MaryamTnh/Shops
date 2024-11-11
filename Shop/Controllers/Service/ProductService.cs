using Domain.Entity;
using Domain.Interface;

namespace Shop.Controllers.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductService _productService;
        public ProductService(IProductService productService)
        {
            _productService = productService;
        }
        public async Task Add(ProductEntity product)
        {
            await _productService.Add(product);
        }

        public async Task Delete(ProductEntity product)
        {
            await _productService.Delete(product);
        }

        public async Task<IEnumerable<ProductEntity>> GetAll()
        {
            return  await _productService.GetAll();
        }

        public async Task<ProductEntity> GetById()
        {
            return await _productService.GetById();
        }

        public async Task<CategoryProductEntity> GetCategoryProductId()
        {
            return await _productService.GetCategoryProductId();
        }

        public async Task Update(ProductEntity product)
        {
            await _productService.Update(product);
        }
    }
}
