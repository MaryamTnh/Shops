using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IBlogCategoryService
    {
        Task<BlogCategoryEntity> GetById();
        Task<IEnumerable<BlogCategoryEntity>> GetAll();
        Task<IEnumerable<BlogEntity>> GetBlogsIdByCategory();
        Task Add(BlogCategoryEntity blogCategory);
        Task Update(BlogCategoryEntity blogCategory);
        Task Delete(int blogcategoryId);
    }
}
