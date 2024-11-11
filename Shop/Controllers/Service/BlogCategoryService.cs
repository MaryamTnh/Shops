using Domain.Entity;
using Domain.Interface;

namespace Shop.Controllers.Service
{
    public class BlogCategoryService : IBlogCategoryService
    {
        private readonly IBlogCategoryService _BlogCategoryService;
        public BlogCategoryService(IBlogCategoryService BlogCategoryService)
        {
            _BlogCategoryService = BlogCategoryService;
        }

        public async Task Add(BlogCategoryEntity blogCategory)
        {
            await _BlogCategoryService.Add(blogCategory);
        }

        public async Task Delete(int blogcategoryId)
        {
            await _BlogCategoryService.Delete(blogcategoryId);
        }

        public async Task<IEnumerable<BlogCategoryEntity>> GetAll()
        {
            return await _BlogCategoryService.GetAll();
        }

        public async Task<IEnumerable<BlogEntity>> GetBlogsIdByCategory()
        {
            return await _BlogCategoryService.GetBlogsIdByCategory();
        }

        public async Task<BlogCategoryEntity> GetById()
        {
            return await _BlogCategoryService.GetById();
        }

        public async Task Update(BlogCategoryEntity blogCategory)
        {
            await _BlogCategoryService.Update(blogCategory);
        }
    }
}
