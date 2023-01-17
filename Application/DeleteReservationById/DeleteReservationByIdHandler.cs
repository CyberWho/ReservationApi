using System;
using MediatR;

namespace Application.DeleteReservationById
{
	public class DeleteReservationByIdHandler : IRequestHandler<DeleteReservationByIdCommand, bool>
	{
		public DeleteReservationByIdHandler()
		{
		}

        public Task<bool> Handle(DeleteReservationByIdCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

