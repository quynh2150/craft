using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipMigrationDABL.Beans;

namespace ShipMigrationDABL.Interfaces
{
    public interface IGoods
    {
        string Name { get; set; }
        string Description { get; set; }
        float Quantity { get; set; }
        Unit Unit { get; set; }

    }
}
