namespace Api.Models
{
    public class Flight
    {
        public int Id { get; set; }

        public string IataCarrierCode { get; set; }

        public string FlightNumber { get; set; }

        public string FlightDesignator => this.IataCarrierCode + this.FlightNumber;

        public string DepartureTime { get; set; }

        public string DepartureDate { get; set; }

        public string DepartureAirport { get; set; }

        public Seats FlightSeats { get; set; }
    }
}
