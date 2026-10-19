using Microsoft.AspNetCore.Identity;

namespace Kurumsal.Domain.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        // Çok-tenant
        public Guid TenantId { get; set; }                 // zorunlu: kullanıcı bir tenant'a ait

        // Kimlik / profil
        public string Ad { get; set; } = null!;
        public string Soyad { get; set; } = null!;
        public string? TcKimlikNo { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public string? Cinsiyet { get; set; }              // "E", "K" ya da "Diğer" vs.
        public bool AktifMi { get; set; } = true;
        public string? ProfilFotoUrl { get; set; }

        // Personel kartı alanları
        public string? SicilNo { get; set; }
        public string? Unvan { get; set; }                 // Yazılım Geliştirici, Muhasebe Uzmanı...
        public string? Departman { get; set; }             // IT, Finans, Satış...
        public DateTime? IseBaslamaTarihi { get; set; }
        public DateTime? IstenAyrilmaTarihi { get; set; }

        // İletişim / adres
        public string? Iban { get; set; }
        public string? Adres { get; set; }
        public string? PostaKodu { get; set; }
        public Guid? UlkeId { get; set; }
        public Guid? SehirId { get; set; }
        public Guid? IlceId { get; set; }
    }
}
