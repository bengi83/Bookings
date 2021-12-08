using Bookings.Domain.Exceptions;

namespace Bookings.Domain.ValueObjects;

public record BookingWindow
{
  public DateTime Start { get; }
  public DateTime End { get; }

  public BookingWindow(DateTime start, DateTime end)
  {
    if (end < start)
      throw new InvalidBookingWindowRangeException();
    var window = end - start;
    if (window.TotalDays > 90)
      throw new BookingWindowTooLongException();
    Start = start;
    End = end;
  }
}