using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Example
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public ThrowAwayGradeBook(string name)
            : base(name)
        {
            Console.WriteLine("throwaway ctor");
        }

        public override GradeStatistic ComputeStatistic()
        {
            float lowest = float.MaxValue;
            foreach (float grade in _grades)
            {
                lowest = Math.Min(lowest, grade);
            }
            _grades.Remove(lowest);
            return base.ComputeStatistic();
        }
    }
}
