using AutoMapper;
using Kurumsal.Application.DTOs.AppUser;
using Kurumsal.Domain.Entities;

namespace Kurumsal.Application.Mapping
{
    public sealed class AppUserProfile : Profile
    {
        public AppUserProfile()
        {
            // Entity -> DTO
            CreateMap<AppUser, AppUserDto>()
                .ForMember(d => d.KullaniciAdi, m => m.MapFrom(s => s.UserName))
                .ForMember(d => d.Email, m => m.MapFrom(s => s.Email))
                .ForMember(d => d.Telefon, m => m.MapFrom(s => s.PhoneNumber))
                .ForMember(d => d.AdSoyad, m => m.MapFrom(s => $"{s.Ad} {s.Soyad}".Trim()));

            // CreateDto -> Entity (Parola map edilmez)
            CreateMap<AppUserCreateDto, AppUser>()
                .ForMember(d => d.UserName, m => m.MapFrom(s => s.KullaniciAdi))
                .ForMember(d => d.Email, m => m.MapFrom(s => s.Email))
                .ForMember(d => d.PhoneNumber, m => m.MapFrom(s => s.Telefon))
                .ForMember(d => d.Id, m => m.Ignore()); // Guid otomatik

            // UpdateDto -> Entity (null gelenler mevcut değeri bozmasın)
            CreateMap<AppUserUpdateDto, AppUser>()
                .ForMember(d => d.Email, m => m.MapFrom(s => s.Email))
                .ForMember(d => d.PhoneNumber, m => m.MapFrom(s => s.Telefon))
                .ForAllMembers(opt => opt.Condition((src, dest, val) => val != null));
        }
    }
}
