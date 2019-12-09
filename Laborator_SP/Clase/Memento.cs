using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_SP.Clase
{
    public class Memento
    {
        public Element State { get; set; }
        public void setState(Section data)
        {
            State = data.copy();
        }

        public Element getState()
        {
            return State;
        }
    }
}
