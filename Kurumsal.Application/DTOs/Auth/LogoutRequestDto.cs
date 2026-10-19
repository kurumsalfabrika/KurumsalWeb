namespace Kurumsal.Application.DTOs.Auth;

public sealed class LogoutRequestDto
{
    public string RefreshToken { get; set; } = null!;
    public bool RevokeAllForUser { get; set; } = false; // opsiyonel: kullanıcının tüm refresh tokenlarını iptal et
}
