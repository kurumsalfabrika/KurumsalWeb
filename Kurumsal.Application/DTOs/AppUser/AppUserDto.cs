namespace Kurumsal.Application.DTOs.AppUser;

public sealed class AppUserDto
{
    public Guid Id { get; set; }
    public Guid TenantId { get; set; }

    // Identity özet
    public string KullaniciAdi { get; set; } = null!;
    public string? Email { get; set; }
    public string? Telefon { get; set; }

    // Profil / personel özeti
    public string Ad { get; set; } = null!;
    public string Soyad { get; set; } = null!;
    public string AdSoyad => $"{Ad} {Soyad}".Trim();
    public string? Unvan { get; set; }
    public string? Departman { get; set; }
    public bool AktifMi { get; set; }
    public DateTime? IseBaslamaTarihi { get; set; }
    public string? ProfilFotoUrl { get; set; }
}
