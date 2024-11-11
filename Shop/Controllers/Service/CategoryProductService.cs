using Domain.Entity;
using Domain.Interface;

namespace Shop.Controllers.Service
{
    public class CategoryProductService : ICategoryProductService
    {
        private readonly ICategoryProductService _categoryProductService;
        public CategoryProductService(ICategoryProductService categoryProductService)
        {
            _categoryProductService = categoryProductService;
        }
        public async Task Add(CategoryProductEntity categoryproduct)
        {
            await _categoryProductService.Add(categoryproduct);
        }

        public async Task Delete(CategoryProductEntity categoryproduct)
        {
            await _categoryProductService.Delete(categoryproduct);
        }

        public async Task<IEnumerable<CategoryProductEntity>> GetAll()
        {
            return await _categoryProductService.GetAll();
        }

        public async Task<CategoryProductEntity> GetById()
        {
            return await _categoryProductService.GetById();
        }

        public async Task<IEnumerable<ProductEntity>> GetProductIdByCategoryProduct()
        {
            return await _categoryProductService.GetProductIdByCategoryProduct();
        }

        public async Task Update(CategoryProductEntity categoryproduct)
        {
            await _categoryProductService.Update(categoryproduct);
        }
    }
}
