namespace Kurumsal.Application.DTOs.AppUser;

public sealed class AppUserCreateDto
{
    public Guid TenantId { get; set; }                 // zorunlu
    public string KullaniciAdi { get; set; } = null!;
    public string Parola { get; set; } = null!;
    public string? Email { get; set; }
    public string? Telefon { get; set; }

    // Profil
    public string Ad { get; set; } = null!;
    public string Soyad { get; set; } = null!;
    public string? TcKimlikNo { get; set; }
    public DateTime? DogumTarihi { get; set; }
    public string? Cinsiyet { get; set; }              // ileride enum'a dönebilir
    public bool AktifMi { get; set; } = true;
    public string? ProfilFotoUrl { get; set; }

    // Personel
    public string? SicilNo { get; set; }
    public string? Unvan { get; set; }
    public string? Departman { get; set; }
    public DateTime? IseBaslamaTarihi { get; set; }

    // İletişim / adres
    public string? Iban { get; set; }
    public string? Adres { get; set; }
    public string? PostaKodu { get; set; }
    public Guid? UlkeId { get; set; }
    public Guid? SehirId { get; set; }
    public Guid? IlceId { get; set; }
}
