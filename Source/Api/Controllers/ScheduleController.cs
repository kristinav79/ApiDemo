namespace Api.Controllers
{
    using System.Linq;
    using Api.DataStore;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/flights")]
    public class ScheduleController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetFlights()
        {
            return this.Ok(Schedules.Current.ScheduleList);
        }

        [HttpGet("{id}")]
        public IActionResult GetFlights(int id)
        {
            var results = Schedules.Current.ScheduleList.FirstOrDefault(flight => flight.Id == id);
            if (results == null)
            {
                return this.NotFound();
            }

            return this.Ok(results);
        }
    }
}
