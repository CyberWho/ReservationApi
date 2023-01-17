using System;
using MediatR;

namespace Application.UpdateReservation
{
	public class UpdateReservationHandler : IRequestHandler<UpdateReservationCommand, bool>
	{
		public UpdateReservationHandler()
		{
		}

        public Task<bool> Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

