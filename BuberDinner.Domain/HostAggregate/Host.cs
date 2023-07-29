using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.HostAggregate.ValueObjects;
using BuberDinner.Domain.MenuAggregate.ValueObjects;

namespace BuberDinner.Domain.HostAggregate;

public sealed class Host : AggregateRoot<HostId, Guid>
{
    private readonly List<MenuId> _menuIds = new();

    public IReadOnlyList<MenuId> MenuIds => _menuIds.AsReadOnly();
}