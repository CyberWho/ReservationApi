using System;
using Domain;
using MediatR;

namespace Application.UpdateReservation
{
	public record UpdateReservationCommand(Reservation Reservation) : IRequest<bool>
	{
		public Reservation Reservation { get; set; } = Reservation;
	}
}

