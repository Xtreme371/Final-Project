using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class FlightTime
    {
        private int id;
        DateTime departuretime;
        DateTime arrivaltime;

        public int Id { get => id; set => id = value; }
        public DateTime Departuretime { get => departuretime; set => departuretime = value; }
        public DateTime Arrivaltime { get => arrivaltime; set => arrivaltime = value; }

        public FlightTime(int id, DateTime departuretime, DateTime arrivaltime)
        {
            this.id = id;
            this.departuretime = departuretime;
            this.arrivaltime = arrivaltime;
        }
        public FlightTime()
        {

        }
    }
}
