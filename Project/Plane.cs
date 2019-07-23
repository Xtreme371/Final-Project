using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Plane
    {
        private int id;
        private string name;
        private string type;
        private double fuel;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public double Fuel { get => fuel; set => fuel = value; }

        public Plane(int id, string name, string type, double fuel)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.fuel = fuel;
        }
        public Plane()
        {

        }
    }
}
