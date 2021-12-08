using Bookings.Domain.Entities;
using Bookings.Domain.ValueObjects;

namespace Bookings.Domain.Factories;

public sealed class BookingFactory
{
  public Booking Create(BookingId id, Person person, Room room, BookingWindow window, Money price)
    => new(id, person, room, window, price);
}