using System;
using Domain;
using MediatR;

namespace Application.GetUserReservations
{
	public record GetUserReservationsCommand(Guid UserId) : IRequest<IReadOnlyList<Reservation>>
	{
		public Guid UserId { get; set; } = UserId;
	}
}

