using ShipMigrationDABL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMigrationDABL.Beans
{
    class VehicleType : IVehicleType
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public VehicleType()
        {
        }

        public string getVehicleTypeName()
        {
            return this.Name;
        } 
    }
}
