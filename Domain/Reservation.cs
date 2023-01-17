using System;
namespace Domain
{
	public class Reservation
	{
        public Reservation(Guid id, Guid userId, int price, int noOfNights, DateTime startDate, DateTime endDate)
        {
            Id = id;
            UserId = userId;
            Price = price;
            NoOfNights = noOfNights;
            StartDate = startDate;
            EndDate = endDate;
        }

        public Guid Id { get; set; } = Guid.Empty;
		public Guid UserId { get; set; }
		public int Price { get; set; }
		public int NoOfNights { get; set; }
		public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

