using System;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ReservationApi.Controllers
{
	[ApiController]
	public class ReservationController : ControllerBase
	{
		private readonly ISender _sender;

        public ReservationController(ISender sender)
        {
            _sender = sender;
        }

		
	}
}

