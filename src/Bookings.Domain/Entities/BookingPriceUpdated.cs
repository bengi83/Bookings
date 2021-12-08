using Bookings.Domain.ValueObjects;
using Bookings.Shared.Abstractions.Domain;

namespace Bookings.Domain.Entities;

public record BookingPriceUpdated(Booking Booking) : IDomainEvent;