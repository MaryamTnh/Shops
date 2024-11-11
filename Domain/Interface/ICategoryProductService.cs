using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface ICategoryProductService
    {
        Task<CategoryProductEntity> GetById();
        Task<IEnumerable<CategoryProductEntity>> GetAll(); 
        Task<IEnumerable<ProductEntity>> GetProductIdByCategoryProduct();
        Task Add(CategoryProductEntity categoryproduct);
        Task Update(CategoryProductEntity categoryproduct);
        Task Delete(CategoryProductEntity categoryproduct);
    }
}
