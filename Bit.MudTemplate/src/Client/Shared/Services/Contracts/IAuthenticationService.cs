using MudTemplate.Shared.Dtos.Account;

namespace MudTemplate.Client.Shared.Services.Contracts;

public interface IAuthenticationService
{
    Task SignIn(SignInRequestDto dto);

    Task SignOut();
}
