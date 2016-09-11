using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Example
{
    public class GradeStatistic
    {
        public GradeStatistic()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

        public string Description
        {
            get
            {
                string result;
                switch (LetterGrade)
                {
                    case 'A':
                        result = "Excellent";
                        break;
                    case 'B':
                        result = "Good";
                        break;
                    default:
                        result = "Fail";
                        break;
                }
                return result;
            }
        }

        public char LetterGrade {
            get
            {
                char result;
                if(AverageGrade >= 90)
                {
                    result = 'A';
                }
                else if(AverageGrade >= 80)
                {
                    result = 'B';
                }
                else
                {
                    result = 'F';
                }
                return result;
            }
        }
    }
}
