using Bookings.Domain.Entities;
using Bookings.Domain.ValueObjects;

namespace Bookings.Domain.Repositories;

public interface IBookingRepository
{
  Task<Booking> GetAsync(BookingId id);
  Task AddAsync(Booking booking);
  Task UpdateAsync(Booking booking);
  Task DeleteAsync(Booking booking);
}