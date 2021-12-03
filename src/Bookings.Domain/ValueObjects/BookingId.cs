using Bookings.Domain.Exceptions;

namespace Bookings.Domain.ValueObjects;

public record BookingId
{
  public Guid Value { get; }

  public BookingId(Guid value)
  {
    if (value == Guid.Empty)
      throw new EmptyBookingIdException();
    Value = value;
  }

  public static implicit operator Guid(BookingId id)
    => id.Value;

  public static implicit operator BookingId(Guid id)
    => new(id);
}