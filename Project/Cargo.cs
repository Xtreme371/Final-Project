using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Project
{
    class Cargo
    {
        private int cargoID;
        private string cargoName;
        private string cargoType;
        private double weight;
        private int aircraftIDFK;


        public int CargoID { get => cargoID; set => cargoID = value; }
        public string CargoName { get => cargoName; set => cargoName = value; }
        public string CargoType { get => cargoType; set => cargoType = value; }
        public double Weight { get => weight; set => weight = value; }
        public int AircraftIDFK { get => aircraftIDFK; set => aircraftIDFK = value; }

        public Cargo()
        {

        }

        public Cargo(int cargoID, string cargoName, string cargoType, double weight, int aircraftIDFK)
        {
            this.cargoID = cargoID;
            this.cargoName = cargoName;
            this.cargoType = cargoType;
            this.weight = weight;
            this.aircraftIDFK = aircraftIDFK;
        }
        public List<Cargo> GetAllWeapons()
        {
            List<Cargo> weapons = new List<Cargo>();
            DataHandler dh = new DataHandler();
            DataSet data = dh.ReadData("tblReport");

            foreach (DataRow item in data.Tables["tblReport"].Rows)
            {
                weapons.Add(
                    new Cargo(
                        int.Parse(item["CargoID"].ToString()),
                         item["CargoName"].ToString(),
                          item["CargoType"].ToString(),
                          double.Parse(item["Weight"].ToString()),
                           int.Parse(item["AircraftIDFK"].ToString())));
            }
            return weapons;
        }
        public int UpdateWeapons(double Weight, int CargoID)
        {
            DataHandler dh = new DataHandler();
            int change = dh.UpdateWeapons(Weight, CargoID);
            return change;
        }
    }
}
