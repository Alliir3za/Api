﻿using Avn.Domain.Dtos;

namespace Avn.Services.Interfaces;

public interface IAccountService : IScopedDependency
{
    Task<IActionResponse<UserTokenDto>> LoginAsync(UserLoginDto userLoginDto, CancellationToken cancellationToken = default);
    Task<IActionResponse<UserTokenDto>> RefreshTokenAsync(string refreshToken, CancellationToken cancellationToken = default);
    Task<IActionResponse> LogoutAsync(Guid userId,string refreshToken, CancellationToken cancellationToken = default);
    Task<IActionResponse<UserDto>> GetCurrentUserAsync(Guid userId, CancellationToken cancellationToken = default);
}
