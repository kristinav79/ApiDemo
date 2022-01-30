namespace Api.Controllers
{
    using System.Linq;
    using Api.DataStore;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/flightDesignator/{flightDesignator}/seats")]
    public class SeatsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetFlightSeats(string flightDesignator)
        {
            var flight = Schedules.Current.ScheduleList.FirstOrDefault(flight => flight.FlightDesignator == flightDesignator);

            if (flight == null)
            {
                return this.NotFound();
            }

            return this.Ok(flight);
        }
    }
}
