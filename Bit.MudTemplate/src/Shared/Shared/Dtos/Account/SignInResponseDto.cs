using MudTemplate.Shared.Attributes;
using MudTemplate.Shared.Resources;

namespace MudTemplate.Shared.Dtos.Account;

[DtoResourceType(typeof(AppStrings))]
public class SignInResponseDto
{
    public string? AccessToken { get; set; }

    public long ExpiresIn { get; set; }
}
