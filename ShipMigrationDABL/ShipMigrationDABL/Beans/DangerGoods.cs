using ShipMigrationDABL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMigrationDABL.Beans
{
    class DangerGoods : IGoods
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public float Quantity { get; set; }
        public Unit Unit { get; set; }
        public int UN { get; set; }


    }
}
