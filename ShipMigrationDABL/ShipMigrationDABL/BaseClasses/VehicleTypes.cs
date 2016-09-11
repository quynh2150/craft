using ShipMigrationDABL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMigrationDABL.BaseClasses
{
    class VehicleTypes
    {
        private HashSet<IVehicleType> _types;
        public VehicleTypes()
        {
            _types = new HashSet<IVehicleType>();
        }

        public void SetVehicleTypes(IVehicleType vehicleType)
        {
            _types.Add(vehicleType);
        }
    }
}
