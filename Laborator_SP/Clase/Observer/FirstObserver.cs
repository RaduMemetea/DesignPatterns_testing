using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_SP.Clase
{
    class FirstObserver : Observer
    {

        public void update(string oldValue, string newValue, string type)
        {
            Console.WriteLine("#1 OldValue: {0}\nNewValue: {1}", oldValue, newValue);

        }
    }
}
