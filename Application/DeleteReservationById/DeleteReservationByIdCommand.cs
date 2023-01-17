using System;
using MediatR;

namespace Application.DeleteReservationById
{
	public record DeleteReservationByIdCommand(Guid ReservationId) : IRequest<bool>
	{
		public Guid ReservationId { get; set; } = ReservationId;
	}
}

