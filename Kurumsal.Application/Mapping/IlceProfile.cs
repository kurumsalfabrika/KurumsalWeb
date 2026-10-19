using AutoMapper;
using Kurumsal.Application.DTOs.Ilce;
using Kurumsal.Domain.Entities;

namespace Kurumsal.Application.Mapping
{
    public class IlceProfile : Profile
    {
        public IlceProfile()
        {
            CreateMap<Ilce, IlceDto>()
                .ForMember(d => d.SehirAd, o => o.MapFrom(s => s.Sehir.Ad));

            CreateMap<IlceCreateDto, Ilce>();
            CreateMap<IlceUpdateDto, Ilce>();
        }
    }
}
