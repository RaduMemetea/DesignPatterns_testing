using Laborator_SP.Clase;

namespace Laborator_SP.Clase
{
    internal class UndoCommand : Command
    {
        Command comanda;
        public void execute()
        {
            comanda = DocumentManager.Instance.stackUndo.Pop();
            comanda.unexecute();
            DocumentManager.Instance.stackRedo.Push(comanda);
        }

        public void unexecute()
        {
            comanda.execute();   
        }
    }
}