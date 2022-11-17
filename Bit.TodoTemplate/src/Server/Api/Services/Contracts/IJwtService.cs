using MudTemplate.Server.Api.Models.Account;
using MudTemplate.Shared.Dtos.Account;

namespace MudTemplate.Server.Api.Services.Contracts;

public interface IJwtService
{
    Task<SignInResponseDto> GenerateToken(User user);
}
