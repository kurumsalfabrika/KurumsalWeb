using Kurumsal.Core.DataAccess.EntityFramework;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;

namespace Kurumsal.DataAccess.Concrete.EntityFramework
{
	public class EfBlogDal : EfEntityRepositoryBase<Blog, KurumsalContext>, IBlogDal
    {
    }
   
}
