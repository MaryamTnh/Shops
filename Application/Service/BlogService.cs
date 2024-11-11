using Domain.Entity;
using Domain.Interface;

namespace Shop.Controllers.Service
{
    public class BlogService : IBlogService
    {
        private readonly IBlogService _blogService;
        public BlogService(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public async Task Add(BlogEntity blog)
        {

            await _blogService.Add(blog);
        }

        public async Task Delete(BlogEntity blog)
        {
            await _blogService.Delete(blog);
        }

        public async Task<IEnumerable<BlogEntity>> GetAll()
        {
            return await _blogService.GetAll();
        }

        public async Task<BlogCategoryEntity> GetBlogCategoryId()
        {
            return await _blogService.GetBlogCategoryId();
        }

        public async Task<BlogEntity> GetById()
        {
            return await _blogService.GetById();
        }

        public async Task Update(BlogEntity blog)
        {
            await _blogService.Update(blog);
        }
    }
}
