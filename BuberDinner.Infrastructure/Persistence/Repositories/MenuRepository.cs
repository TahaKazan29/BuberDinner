using BuberDinner.Application.Persistence;
using BuberDinner.Domain.HostAggregate.ValueObjects;
using BuberDinner.Domain.MenuAggregate;

namespace BuberDinner.Infrastructure.Persistence.Repositories;

public class MenuRepository : IMenuRepository
{
    private readonly BuberDinnerDbContext _dbContext;

    public MenuRepository(BuberDinnerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(Menu menu)
    {
        _dbContext.Add(menu);
        _dbContext.SaveChanges();
    }

    // public Menu? GetMenuByHost(string hostId)
    // {
    //     return _menus.SingleOrDefault(u => u.HostId == HostId.CreateUnique());
    // }
}