namespace Bookings.Shared.Abstractions.Exceptions;

public abstract class BookingsException : Exception
{
  public BookingsException(string message)
   : base(message)
  {
  }

  public BookingsException(string message, Exception innerException)
    : base(message, innerException)
  {
  }
}