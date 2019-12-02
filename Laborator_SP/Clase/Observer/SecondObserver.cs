using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_SP.Clase
{
    class SecondObserver : Observer
    {

        public void update(string oldValue, string newValue, string type)
        {
            Console.WriteLine("#2 OldValue: {0}\nNewValue: {1}", oldValue, newValue);
        }
    }
}
