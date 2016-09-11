using ShipMigrationDABL.BaseClasses;
using ShipMigrationDABL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMigrationDABL.Beans
{
    public class Ship : IVehicleType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public Country National { get; set; }
        public string ShipType { get; set; }
        public string CallSign { get; set; }
        public DateTime RegisteredDate { get; set; }
        public string License { get; set; } 
        public string Description { get; set; }

        public Crews Crews { get; set; }
        //public Voyage Voyage { get; set; }

    }
}
