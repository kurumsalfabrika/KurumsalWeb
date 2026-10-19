using Kurumsal.Core.DataAccess.EntityFramework;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;

namespace Kurumsal.DataAccess.Concrete.EntityFramework
{
    public class EfSSSDal : EfEntityRepositoryBase<SSS, KurumsalContext>, ISSSDal
    {
    }
   
}
