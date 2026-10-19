using Kurumsal.Core.DataAccess.EntityFramework;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Kurumsal.DataAccess.Concrete.EntityFramework
{

    public class EfApiAyarDal : EfEntityRepositoryBase<ApiAyar, KurumsalContext>, IApiAyarDal
    {

    }


}


