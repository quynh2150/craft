using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = new DateTime(1974,8,15);
            DateTime endDate = DateTime.Now.ToLocalTime();

            var hours = (endDate - startDate).TotalHours;
            Console.WriteLine(hours.ToString());

            var days = (int)hours / 24;
            var extendDays = (int)hours % 24;
            Console.WriteLine(days);
            var month =  (float)hours/

            Console.Read();
        }
    }
}
