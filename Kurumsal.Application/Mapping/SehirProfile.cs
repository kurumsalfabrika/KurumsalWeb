using AutoMapper;
using Kurumsal.Application.DTOs.Sehir;
using Kurumsal.Domain.Entities;

namespace Kurumsal.Application.Mapping
{
    public class SehirProfile : Profile
    {
        public SehirProfile()
        {
            CreateMap<Sehir, SehirDto>().ReverseMap();
            CreateMap<Sehir, SehirCreateDto>().ReverseMap();
            CreateMap<Sehir, SehirUpdateDto>().ReverseMap();
        }
    }
}
