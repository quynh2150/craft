using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {

        //static void ConsoleWrite(double data)
        //{
        //    Console.WriteLine(data);
        //}

        static void Main(string[] args)
        {
            //ver 1: Action<double> print = ConsoleWrite;
            //ver 2: Action<double> print = delegate(double data)
            //{
            //    Console.WriteLine(data);
            //};

            Action<bool> print = d => Console.WriteLine(d);
            Func<double, double> square = d => d * d;
            Func<double, double, double> add = (x, y) => x + y;
            Predicate<double> isLessThanTen = d => d < 10;

            print(isLessThanTen(square(add(3, 5))));

            var buffer = new Buffer<double>();

            ProcessInput(buffer);

            //var consoleOut = new Printer<double>(ConsoleWrite);
            //buffer.Dump(print);

            var asInts = buffer.AsEnumerableOf<double, int>();
            foreach (var item in asInts)
            {
                Console.WriteLine(item);
            }

            ProcessBuffer(buffer);

            Console.Read();
        }

        private static void ProcessBuffer(IBuffer<double> buffer)
        {
            var sum = 0.0;
            Console.WriteLine("Buffer: ");
            while (!buffer.IsEmpty)
            {
                sum += buffer.Read();
            }
            Console.WriteLine(sum);
        }

        private static void ProcessInput(IBuffer<double> buffer)
        {
            while (true)
            {
                var value = 0.0;
                var input = Console.ReadLine();
            }
        }
    }
}
