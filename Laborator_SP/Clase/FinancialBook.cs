using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_SP.Clase
{
    class FinancialBook : BookStatistics
    {
        
        double image_price = 5;
        double paragraph_price = 1.25;
        double table_price = 2.10;

       
        public void getStatisitcs()
        {
            Console.WriteLine($"Total image price is {imageCounter*image_price}\n" +
                $"Total paragraph price is {paragraphCounter*paragraph_price}\n" +
                $"Total table price is {tableCounter*table_price}\n");
        }
    }

}
