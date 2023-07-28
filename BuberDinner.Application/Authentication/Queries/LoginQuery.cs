using BuberDinner.Application.Services.Authentication.Common;
using ErrorOr;
using MediatR;

namespace BuberDinner.Application.Authentication.Commands.Register;

public record LoginQuery(string Email, string Password) : IRequest<ErrorOr<AuthenticationResult>>;