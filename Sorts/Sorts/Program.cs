using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 5, 6, 2, 2, 10, 12, 9, 10, 9, 3 };
            //SelectionSort selection = new SelectionSort(input);
            //selection.Sort();
            //selection.PrintOut();
            InputArray<int> array = new InputArray<int>();


            foreach (var item in input)
            {
                Console.WriteLine(item.ToString());
            }
            Console.Read();
        }
    }
}
