using System;
using Domain;
using MediatR;

namespace Application.GetUserReservations
{
	public class GetUserReservationsHandler : IRequestHandler<GetUserReservationsCommand, IReadOnlyList<Reservation>>
	{
		public GetUserReservationsHandler()
		{
		}

        public Task<IReadOnlyList<Reservation>> Handle(GetUserReservationsCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

