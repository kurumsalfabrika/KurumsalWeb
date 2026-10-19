using Kurumsal.Business.Abstract;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurumsal.Business.Concrete
{
	public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public async Task AddAsync(Blog blog)
        {
            await _blogDal.AddAsync(blog);
        }

        public async Task DeleteAsync(int blogId)
        {
            await _blogDal.DeleteAsync(new Blog { Id = blogId });
        }

        public async Task<List<Blog>> GetAllAsync()
        {
            return await _blogDal.GetListAsync();
        }

        public async Task<Blog> GetByIdAsync(int blogId)
        {
            return await _blogDal.GetAsync(x => x.Id == blogId);
        }

        public async Task<Blog> GetByNameAsync(string blogName)
        {
            return await _blogDal.GetAsync(x => x.Baslik == blogName);
        }

        public async Task UpdateAsync(Blog blog)
        {
            await _blogDal.UpdateAsync(blog);
        }
    }
}
