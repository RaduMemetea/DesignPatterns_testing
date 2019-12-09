using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_SP.Clase
{
    public class DeleteCommand : Command
    {
        Memento memento = new Memento();
        public void execute()
        {
            var data = ((Section)DocumentManager.Instance.getBook().Sections[0]);
            var elem = data.Content.ElementAt(data.Content.Count - 1);

            memento.setState(data);

            data.Content.Remove(elem);

            DocumentManager.Instance.stackUndo.Push(this);
           
        }

        public void unexecute()
        {
            var data = DocumentManager.Instance.getBook().Sections;
           
            data.Clear();
            data.Add(memento.getState());

            var data2 = ((Section)DocumentManager.Instance.getBook().Sections[0]);
            memento.setState(data2);
        }

        

    }
}
