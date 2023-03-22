using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation.Data
{
    public class Flights
    {
        public Flights(string flightCode, string airlineName, string to, string from, string day, string hour, int maxSeats, decimal price)
        {
            FlightCode = flightCode;
            AirlineName = airlineName;
            To = to;
            From = from;
            Day = day;
            Hour = hour;
            MaxSeats = maxSeats;
            Price = price;
        }

        public string FlightCode { get; set; }
        public string AirlineName { get; set; }
        public string To { get; set; }
        public string From { get; set; }

        public string Day { get; set; }
        public string Hour { get; set; }
        public int MaxSeats { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Flight {FlightCode} operated by {AirlineName} from {From} to {To} at {Hour}. Maximum number of seats: {MaxSeats}. Price: {Price:C}";
        }
    }
}