using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_SP.Clase
{
    class RedoCommand : Command
    {
        Command command;
        public void execute()
        {
            command = DocumentManager.Instance.stackRedo.Pop();
            command.execute();
            DocumentManager.Instance.stackUndo.Push(command);
        }

        public void unexecute()
        {
            command.unexecute();
        }
    }
}
