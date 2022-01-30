namespace Api.DataStore
{
    using System.Collections.Generic;
    using Api.Models;

    public class Schedules
    {
        public Schedules()
        {
            this.ScheduleList = new List<Flight>()
            {
                new Flight()
                {
                    Id = 1,
                    IataCarrierCode = "FR",
                    FlightNumber = "1234",
                    DepartureAirport = "KUN",
                    DepartureDate = "2022-01-01",
                    DepartureTime = "20:00",
                    FlightSeats = new Seats
                    {
                        BussnessClassSeats = 5,
                        EconomyClassSeats = 4,
                    },
                },
                new Flight()
                {
                    Id = 2,
                    IataCarrierCode = "FR",
                    FlightNumber = "3333",
                    DepartureAirport = "VLN",
                    DepartureDate = "2022-01-02",
                    DepartureTime = "20:15",
                    FlightSeats = new Seats
                    {
                        BussnessClassSeats = 5,
                        EconomyClassSeats = 4,
                    },
                },
            };
        }

        public static Schedules Current { get; } = new Schedules();

        public List<Flight> ScheduleList { get; set; }
    }
}
