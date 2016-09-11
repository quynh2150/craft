using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //GradeBook book = new ThrowAwayGradeBook("My Book");
            IGradeTracker book = CreateGradeBook();

            try
            {
                using (FileStream stream = File.Open("grades.txt", FileMode.Open))
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = reader.ReadLine();
                    //string[] lines = File.ReadAllLines("grades.txt");
                    while (line != null)
                    {
                        float grade = float.Parse(line);
                        book.AddGrade(grade);
                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Could not locate the file grades.txt");
                return;
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("No access");
                return;
            }

            book.DoSomething();
            book.WriteGrades(Console.Out);

            try
            {
                //Console.WriteLine("Please entern the name of the book");
                //book.Name = Console.ReadLine();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("invalid name");
            }

            WriteNames(book.Name);

            //Original: book.NameChanged = new NameChangedDelegate(OnNameChanged);
            //book.NameChanged += OnNameChanged;

            GradeStatistic stats = book.ComputeStatistic();

            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.LowestGrade);

            Console.Read();
        }

        private static IGradeTracker CreateGradeBook()
        {
            IGradeTracker book = new ThrowAwayGradeBook("My book");
            return book;
        }

        //using delegate
        private static void OnNameChanged(string oldValue, string newValue)
        {
            Console.WriteLine("Name changed from {0} to {1} with delegate", oldValue, newValue);
        }

        //using event
        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Name changed from {0} to {1} with event", args.OldValue, args.NewValue);
        }

        private static void WriteBytes(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);
        }

        private static void WriteBytes(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            WriteByteArray(bytes);
        }

        private static void WriteByteArray(byte[] bytes)
        {
            foreach (byte b in bytes)
            {
                Console.WriteLine("0x{0:X} ", b);
            }
            Console.WriteLine();
            Console.Read();
        }

        private static void WriteNames(params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
