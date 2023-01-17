using System;
using MediatR;

namespace Application.CreateReservation
{
	public class CreateReservationHandler : IRequestHandler<CreateReservationCommand, bool>
	{
		public CreateReservationHandler()
		{
		}

        public Task<bool> Handle(CreateReservationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

