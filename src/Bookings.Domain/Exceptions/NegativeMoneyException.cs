using Bookings.Shared.Abstractions.Exceptions;

namespace Bookings.Domain.Exceptions;

public class NegativeMoneyException : BookingsException
{
  public NegativeMoneyException() 
    : base("Money cannot have a negative value.")
  {
  }
}