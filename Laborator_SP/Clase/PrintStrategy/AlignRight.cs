using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_SP.Clase
{
    class AlignRight:AlingnStrategy
    {
        public void print(String Text)
        {
            Console.WriteLine($"Paragraph: {Text} +++");
        }
    }
}
