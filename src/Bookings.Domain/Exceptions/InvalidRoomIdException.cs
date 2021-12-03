using Bookings.Shared.Abstractions.Exceptions;

namespace Bookings.Domain.Exceptions;

public class InvalidRoomIdException : BookingsException
{
  public InvalidRoomIdException()
    : base("Room ID must be a non-zero positive integer.")
  {
  }
}