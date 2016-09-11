using ShipMigrationDABL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMigrationDABL.Beans
{
    public class Crew : IPerson
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public Country Country { get; set; }
        public string ID { get; set; }
        public char Gender { get; set; }
        public string Position { get; set; }
    }
}
