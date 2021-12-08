using Bookings.Domain.Exceptions;

namespace Bookings.Domain.ValueObjects;

public class Money
{
  public decimal Value { get; }

  public Money(decimal value)
  {
    if (value < 0m)
      throw new NegativeMoneyException();
    Value = value;
  }

  public static implicit operator decimal(Money money)
    => money.Value;
  
  public static implicit operator Money(decimal money)
    => new(money);
}