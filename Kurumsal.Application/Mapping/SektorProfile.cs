using AutoMapper;
using Kurumsal.Application.DTOs.Sektor;
using Kurumsal.Domain.Entities;

namespace Kurumsal.Application.Mapping
{
    public class SektorProfile : Profile
    {
        public SektorProfile()
        {
            CreateMap<Sektor, SektorDto>().ReverseMap();
            CreateMap<SektorCreateDto, Sektor>();
            CreateMap<SektorUpdateDto, Sektor>();
        }
    }
}
