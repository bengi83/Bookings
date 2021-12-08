using Bookings.Domain.ValueObjects;
using Bookings.Shared.Abstractions.Domain;

namespace Bookings.Domain.Entities;

public record BookingWindowUpdated(Booking Booking) : IDomainEvent;