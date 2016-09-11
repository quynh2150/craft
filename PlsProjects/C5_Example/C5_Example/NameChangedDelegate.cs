using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C5_Example
{
    //Original: public delegate void NameChangedDelegate(string oldValue, string newValue);
    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);
    
}
