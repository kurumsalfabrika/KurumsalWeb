using AutoMapper;
using Kurumsal.Application.DTOs.Role;
using Kurumsal.Domain.Entities;

namespace Kurumsal.Application.Mapping
{
    public class AppRoleProfile : Profile
    {
        public AppRoleProfile()
        {
            CreateMap<AppRole, AppRoleDto>();
            CreateMap<AppRoleCreateDto, AppRole>();
            CreateMap<AppRoleUpdateDto, AppRole>();
        }
    }
}
