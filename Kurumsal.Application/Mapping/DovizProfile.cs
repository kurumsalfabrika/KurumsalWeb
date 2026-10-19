using AutoMapper;
using Kurumsal.Application.DTOs.Doviz;
using Kurumsal.Domain.Entities;

namespace Kurumsal.Application.Mapping
{
    public class DovizProfile : Profile
    {
        public DovizProfile()
        {
            CreateMap<Doviz, DovizDto>();
            CreateMap<DovizCreateDto, Doviz>();
            CreateMap<DovizUpdateDto, Doviz>();
        }
    }
}
