using Bookings.Domain.Entities;
using Bookings.Shared.Abstractions.Domain;

namespace Bookings.Domain.Events;

public record BookingCancelled(Booking Booking) : IDomainEvent;