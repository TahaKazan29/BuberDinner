using BuberDinner.Domain.UserAggregate;

namespace BuberDinner.Application.Services.Authentication.Common;

public record AuthenticationResult(
    User User,
    string Token
);