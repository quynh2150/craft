using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedvsList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            for(int i=0; i<5; i++)
            {
                linkedList.AddLast(i);
            }

            Console.WriteLine(linkedList.Count());

            for(LinkedListNode<int> node = linkedList.First; node!= linkedList.Last.Next;
                node = node.Next)
            {
                //linkedList.AddLast(10);
                Console.WriteLine(node.Value);
            }

            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            foreach (var item in list)
            {
                list.Add(10);
                Console.WriteLine(item.ToString());
            }
            Console.Read();
        }
    }
}
