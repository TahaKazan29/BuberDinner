using BuberDinner.Application.Common.Services;

namespace BuberDinner.Infrastructure.Authentication.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}