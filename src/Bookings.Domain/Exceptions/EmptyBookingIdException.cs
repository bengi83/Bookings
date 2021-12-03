using Bookings.Shared.Abstractions.Exceptions;

namespace Bookings.Domain.Exceptions;

public class EmptyBookingIdException : BookingsException
{
  public EmptyBookingIdException()
    : base("Booking ID cannot be empty.")
  {
  }
}