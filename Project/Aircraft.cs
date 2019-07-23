using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class Aircraft
    {
        private int aircraftID;
        private string aircraftName;
        private string aircraftType;
        private int aircraftFuel;
        

        public int AircraftID { get => aircraftID; set => aircraftID = value; }
        public string AircraftName { get => aircraftName; set => aircraftName = value; }
        public string AircraftType { get => aircraftType; set => aircraftType = value; }
        public int AircraftFuel { get => aircraftFuel; set => aircraftFuel = value; }

        public Aircraft()
        {

        }
        public Aircraft(int aircraftID, string aircraftName, string aircraftType, int aircraftFuel)
        {
            this.aircraftID = aircraftID;
            this.aircraftName = aircraftName;
            this.aircraftType = aircraftType;
            this.aircraftFuel = aircraftFuel;
        }
        public List<Aircraft> GetAllPlanes()
        {
            List<Aircraft> planes = new List<Aircraft>();
            DataHandler dh = new DataHandler();
            DataSet data = dh.ReadData("tblAircraft");

            foreach (DataRow item in data.Tables["tblAircraft"].Rows)
            {
                planes.Add(
                    new Aircraft(
                        int.Parse(item["AircraftID"].ToString()),
                         item["AircraftName"].ToString(),
                          item["AircraftType"].ToString(),
                           int.Parse(item["FuelLevel"].ToString())));
            }
            return planes;
        }
        public int UpdateFuel(int AircraftID, int Fuel)
        {
            DataHandler dh = new DataHandler();
            int change = dh.UpdateWeapons(AircraftID, Fuel);
            return change;
        }
    }
}
