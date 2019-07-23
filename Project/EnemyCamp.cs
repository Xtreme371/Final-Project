using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class EnemyCamp
    {
        private int e_campID;
        private string e_campType;
        private int threath_level;
        private string time_identified;
        private int aircraftID;

        public int E_campID { get => e_campID; set => e_campID = value; }
        public string E_campType { get => e_campType; set => e_campType = value; }
        public int Threath_level { get => threath_level; set => threath_level = value; }
        public string Time_identified { get => time_identified; set => time_identified = value; }
        public int AircraftID { get => aircraftID; set => aircraftID = value; }

        public EnemyCamp()
        {

        }

        public EnemyCamp(int e_campID, string e_campType, int threath_level, string time_identified, int aircraftID)
        {
            this.e_campID = e_campID;
            this.e_campType = e_campType;
            this.threath_level = threath_level;
            this.time_identified = time_identified;
            this.aircraftID = aircraftID;
        }

    }
}
