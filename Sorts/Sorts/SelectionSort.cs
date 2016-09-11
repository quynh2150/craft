using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts
{
    //Get the list of input
    //Iterate from i [0...n-1]
    //   find the smallest
    //   swap it back to the i position
    //   countinue to loop

    

    public class SelectionSort<T>
    {
        InputArray<T> input;
        T smallest;
        int smallestIndex;

        public void Sort()
        {
            for (int i = 0; i < input.Count - 2; i++)
            {
                smallest = input.Member(i);
                smallestIndex = i;

                for (int j = i + 1; j <= input.Count - 1; j++)
                {
                    if (input.Member(j). < smallest)
                    {
                        smallest = input.Member(j);
                        smallestIndex = j;
                    }
                }
                temp = input.Member(i);
                input.Member(i) = smallest;
                input[smallestIndex] = temp;

                Swap(input.Member(i), smallest);
            }
        }

        public void PrintOut()
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
