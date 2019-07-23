using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Cargo
    {
        private int id;
        private string name;
        private string type;
        private double weight;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public double Weight { get => weight; set => weight = value; }

        public Cargo(int id, string name, string type, double weight)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.weight = weight;
        }
        public Cargo()
        {

        }
    }
}
