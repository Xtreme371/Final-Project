using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Pilot
    {
        private int pilotID;
        private string pilotName;
        private string pilotSurname;
        private int age;
        private int aircraftIDFK;


        public int PilotID { get => pilotID; set => pilotID = value; }
        public string PilotName { get => pilotName; set => pilotName = value; }
        public string PilotSurname { get => pilotSurname; set => pilotSurname = value; }
        public int Age { get => age; set => age = value; }
        public int AircraftIDFK { get => aircraftIDFK; set => aircraftIDFK = value; }

        public Pilot()
        {

        }
        public Pilot(int pilotID, string pilotName, string pilotSurname, int age, int aircraftIDFK)
        {
            this.pilotID = pilotID;
            this.pilotName = pilotName;
            this.pilotSurname = pilotSurname;
            this.age = age;
            this.aircraftIDFK = aircraftIDFK;
        }
    }
}
