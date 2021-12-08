using Bookings.Shared.Abstractions.Exceptions;

namespace Bookings.Domain.Exceptions;

public class InvalidBookingWindowRangeException : BookingsException
{
  public InvalidBookingWindowRangeException()
    : base("Booking range end date cannot occur before start date.")
  {
  }
}