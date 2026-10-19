namespace Kurumsal.Application.DTOs.Auth;

public sealed class LoginRequestDto
{
    public string KullaniciAdiVeyaEmail { get; set; } = null!;
    public string Parola { get; set; } = null!;
}
