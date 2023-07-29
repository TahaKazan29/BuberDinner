using BuberDinner.Domain.UserAggregate;

namespace BuberDinner.Application.Persistence;

public interface IUserRepository
{

    User? GetUserByEmail(string email);
    void Add(User user);
}