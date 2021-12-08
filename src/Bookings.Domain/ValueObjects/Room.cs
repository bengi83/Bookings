using Bookings.Domain.Exceptions;

namespace Bookings.Domain.ValueObjects;

public record Room
{
  public string Building { get; }
  public int RoomNumber { get; }

  public Room(string building, int roomNumber)
  {
    Building = building;
    RoomNumber = roomNumber;
  }
}