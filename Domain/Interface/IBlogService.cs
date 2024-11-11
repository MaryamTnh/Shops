using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IBlogService
    {
        Task<BlogEntity> GetById();
        Task<IEnumerable<BlogEntity>> GetAll();
        Task<BlogCategoryEntity> GetBlogCategoryId();
        Task Add(BlogEntity blog);
        Task Update(BlogEntity blog);
        Task Delete(BlogEntity blog);
    }
}
