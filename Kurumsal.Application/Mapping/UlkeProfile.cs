using AutoMapper;
using Kurumsal.Application.DTOs.Ulke;
using Kurumsal.Domain.Entities;

namespace Kurumsal.Application.Mapping
{
    public class UlkeProfile : Profile
    {
        public UlkeProfile()
        {
            CreateMap<Ulke, UlkeDto>().ReverseMap();
            CreateMap<Ulke, UlkeCreateDto>().ReverseMap();
            CreateMap<Ulke, UlkeUpdateDto>().ReverseMap();
        }
    }
}
