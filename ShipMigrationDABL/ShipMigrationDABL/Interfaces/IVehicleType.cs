using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMigrationDABL.Interfaces
{
    public interface IVehicleType
    {
        string ID { get; set;}
        string Name { get; set; }
        string Description { get; set; }
    }
}
