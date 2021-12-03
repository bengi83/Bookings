using Bookings.Domain.Exceptions;

namespace Bookings.Domain.ValueObjects;

public class RoomId
{
  public int Value { get; }

  public RoomId(int value)
  {
    if (value <= 0)
      throw new InvalidRoomIdException();
    Value = value;
  }

  public static implicit operator int(RoomId id)
    => id.Value;

  public static implicit operator RoomId(int id)
    => new(id);
}