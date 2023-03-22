using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation.Data
{
    public class Reservation
    {
        public string ReservationCode { get; set; }
        public string PassengerName { get; set; }
        public string Citizenship { get; set; }
        public String FlightCode { get; set; }
        public string Airline { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Day { get; set; }
        public string Hour { get; set; }
        public int Maxseats { get; set; }
        public double Price { get; set; }
    }
}
