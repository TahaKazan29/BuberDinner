using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Common.ValueObjects;

public sealed class Rating : ValueObject
{
    private Rating(double value)
    {
        Value = value;
    }
    public double Value { get; }

    public static Rating CreateNew(double rating = 0)
    {
        return new Rating(rating);
    }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}