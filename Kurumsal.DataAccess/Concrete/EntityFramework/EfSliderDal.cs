using Kurumsal.Core.DataAccess.EntityFramework;
using Kurumsal.DataAccess.Abstract;
using Kurumsal.Entities.Concrete;

namespace Kurumsal.DataAccess.Concrete.EntityFramework
{
    public class EfSliderDal : EfEntityRepositoryBase<Slider, KurumsalContext>, ISliderDal
    {
    }
   
}
