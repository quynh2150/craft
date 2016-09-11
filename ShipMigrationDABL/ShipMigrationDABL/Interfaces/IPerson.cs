using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipMigrationDABL.Beans;

namespace ShipMigrationDABL.Interfaces
{
    public interface IPerson
    {
        string Name { get; set; }
        DateTime BirthDay { get; set; }
        Country Country { get; set; }
        string ID { get; set; }
        char Gender { get; set; }

    }
}
