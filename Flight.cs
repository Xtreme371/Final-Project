using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Flight
    {
        private int flightID;
        private string departureTime;
        private string arrivalTime;
        private int aircraftIDFK;


        public int FlightID { get => flightID; set => flightID = value; }
        public string DepartureTime { get => departureTime; set => departureTime = value; }
        public string ArrivalTime { get => arrivalTime; set => arrivalTime = value; }
        public int AircraftIDFK { get => aircraftIDFK; set => aircraftIDFK = value; }
        public Flight()
        {

        }

        public Flight(int flightID, string departureTime, string arrivalTime, int aircraftIDFK)
        {
            this.flightID = flightID;
            this.departureTime = departureTime;
            this.arrivalTime = arrivalTime;
            this.aircraftIDFK = aircraftIDFK;
        }
    }
}
