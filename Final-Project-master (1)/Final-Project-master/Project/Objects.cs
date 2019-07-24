using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Objects
    {
        private string id;
        private string type;
        private int threatlevel;
        DateTime timeidentified;

        public string Id { get => id; set => id = value; }
        public string Type { get => type; set => type = value; }
        public int Threatlevel { get => threatlevel; set => threatlevel = value; }
        public DateTime Timeidentified { get => timeidentified; set => timeidentified = value; }

        public Objects(string id, string type, int threatlevel, DateTime timeidentified)
        {
            this.id = id;
            this.type = type;
            this.threatlevel = threatlevel;
            this.timeidentified = timeidentified;
        }
        public Objects()
        {

        }
    }
}
