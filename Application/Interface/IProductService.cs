﻿using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IProductService
    {
        Task<ProductEntity> GetById();
        Task<IEnumerable<ProductEntity>> GetAll();
        Task<CategoryProductEntity> GetCategoryProductId();
        Task Add(ProductEntity product);
        Task Update(ProductEntity product);
        Task Delete(ProductEntity product);
    }
}
