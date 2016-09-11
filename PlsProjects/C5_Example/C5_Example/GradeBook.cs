using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Example
{
    public class GradeBook : GradeTracker
    {
        public GradeBook(string name = "There is no name")
        {
            Name = name;
            _grades = new List<float>();
            Console.WriteLine("gradebook ctor");
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                _grades.Add(grade);
            }
        }

        public override GradeStatistic ComputeStatistic()
        {
            GradeStatistic stats = new GradeStatistic();
            float sum = 0f;
            foreach (float grade in _grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Max(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / _grades.Count;
            return stats;
        }

        public override void WriteGrades(TextWriter textWriter)
        {
            textWriter.WriteLine("Grades: ");
            foreach (float grade in _grades)
            {
                textWriter.WriteLine(grade);
            }
            textWriter.WriteLine("*****");
        }

        protected List<float> _grades;

    }
}
