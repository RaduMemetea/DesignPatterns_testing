using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_SP.Clase
{
    class SaveCommand : Command
    {
        string vv;
        public SaveCommand(string v)
        {
            vv = v;
        }

        public void execute()
        {
            throw new NotImplementedException();
        }
    }
}
