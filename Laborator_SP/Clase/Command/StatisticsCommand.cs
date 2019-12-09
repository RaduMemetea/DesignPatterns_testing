using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_SP.Clase
{
    class StatisticsCommand : Command
    {
        public StatisticsCommand()
        {
        }

        public void execute()
        {
            BookStatistics bookStatistics = new BookStatistics();
            foreach (var item in DocumentManager.Instance.getBook().Sections)
            {
                item.accept(bookStatistics);
            }
            bookStatistics.printStatistics();
           
        }

        public void unexecute()
        {
            throw new NotImplementedException();
        }
    }
}
