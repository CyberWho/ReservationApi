using System;
namespace Application.CreateReservation
{
	public class CreateReservationRequest
	{
        public Guid UserId { get; set; }
        public int Price { get; set; }
        public int NoOfNights { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

