using Bookings.Shared.Abstractions.Exceptions;

namespace Bookings.Domain.Exceptions;

public class BookingWindowTooLongException : BookingsException
{
  public BookingWindowTooLongException()
    : base($"Booking window cannot exceed a total of 90 days.")
  {
  }
}