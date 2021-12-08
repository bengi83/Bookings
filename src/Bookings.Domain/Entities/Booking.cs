using Bookings.Domain.Events;
using Bookings.Domain.ValueObjects;
using Bookings.Shared.Abstractions.Domain;

namespace Bookings.Domain.Entities;

public class Booking : AggregateRoot<BookingId>
{
  private Person _person;
  private Room _room;
  private BookingWindow _window;
  private Money _price;
  private bool _cancelled;

  internal Booking(BookingId id, Person person, Room room, BookingWindow window, Money price)
  {
    Id = id;
    _person = person;
    _room = room;
    _window = window;
    _price = price;
    _cancelled = false;
  }

  public void UpdateWindow(BookingWindow window)
  {
    if(_window == window)
      return;
    
    var oldWindow = _window;
    _window = window;
    AddEvent(new BookingWindowUpdated(this));
  }

  public void UpdatePrice(Money price)
  {
    if(_price == price)
      return;
    
    var oldPrice = _price;
    _price = price;
    AddEvent(new BookingPriceUpdated(this));
  }

  public void CancelBooking()
  {
    if (_cancelled)
      return;
    _cancelled = true;
    AddEvent(new BookingCancelled(this));
  }
}