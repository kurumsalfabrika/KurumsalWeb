using Kurumsal.Application.DTOs.Auth;

namespace Kurumsal.Application.Interfaces;

public interface IAuthService
{
    Task<AuthResponseDto> LoginAsync(LoginRequestDto dto);
    Task<AuthResponseDto> RefreshAsync(RefreshRequestDto dto);
    Task<bool> LogoutAsync(LogoutRequestDto dto);
}
