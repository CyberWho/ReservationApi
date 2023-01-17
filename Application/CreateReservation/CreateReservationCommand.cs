using System;
using MediatR;

namespace Application.CreateReservation
{
	public record CreateReservationCommand(CreateReservationRequest Request) : IRequest<bool>
	{
		public CreateReservationRequest Request { get; set; } = Request;
    }
}

