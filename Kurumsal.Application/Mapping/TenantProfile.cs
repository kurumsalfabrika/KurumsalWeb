using AutoMapper;
using Kurumsal.Application.DTOs.Tenant;
using Kurumsal.Domain.Entities;

namespace Kurumsal.Application.Mapping
{
    public class TenantProfile : Profile
    {
        public TenantProfile()
        {
            CreateMap<Tenant, TenantDto>().ReverseMap();
            CreateMap<TenantCreateDto, Tenant>();
            CreateMap<TenantUpdateDto, Tenant>();
        }
    }
}
