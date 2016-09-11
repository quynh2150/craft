using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectIt
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeList = CreateCollection(typeof(List<Employee>));
        }

        private static object CreateCollection(Type type)
        {
            throw new NotImplementedException();
        }
    }

    public class Employee
    {
        public string Name { get; set; }
    }
}
