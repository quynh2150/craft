using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Example
{
    public interface IGradeTracker
    {
        void AddGrade(float grade);
        GradeStatistic ComputeStatistic();
        void WriteGrades(TextWriter textWriter);
        string Name { get; set; }
        event NameChangedDelegate NameChanged;
        void DoSomething();
    }


    public abstract class GradeTracker : IGradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistic ComputeStatistic();
        public abstract void WriteGrades(TextWriter textWriter);

        public void DoSomething()
        {
            
        }

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                if (_name != value)
                {
                    var oldValue = _name;
                    _name = value;

                    //Check to see if someone call the delegate
                    //Original: if (NameChanged != null) { NameChanged(oldValue, value); }
                    //before we have 'NameChangedEventArgs' => NameChanged?.Invoke(oldValue, value);

                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.OldValue = oldValue;
                    args.NewValue = value;
                    NameChanged?.Invoke(this, args);
                }
            }
        }

        public event NameChangedDelegate NameChanged;
    }
}
