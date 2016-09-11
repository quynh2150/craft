using ShipMigrationDABL.Beans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipMigrationDABL.BaseClasses
{
    public class Crews
    {
        private ICollection<Crew> CrewMembers;
        public Crews()
        {
            CrewMembers = new List<Crew>();
        }

        public void AddNewMember(Crew member)
        {
            CrewMembers.Add(member);
        }

        public Crew Captain
        {
            get
            {
                foreach (var member in CrewMembers)
                {
                    if( member.Position == "Captain")
                    {
                        return member;
                    }
                }
                return new Crew();
            }
            set { }
        }

        public bool hasCaptain()
        {
            return String.IsNullOrEmpty(Captain.ID);
        }
    }
}
