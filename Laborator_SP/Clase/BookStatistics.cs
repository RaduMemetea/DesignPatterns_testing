using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_SP.Clase
{
    class BookStatistics : Visitor
    {
        protected int imageCounter { get; private set; } = 0;
        protected int paragraphCounter { get; private set; } = 0;
        protected int tableCounter { get; private set; } = 0;



        public void visit(Image image)
        {
            imageCounter++;
        }

        public void visit(Paragraph paragraph)
        {
            paragraphCounter++;
        }

        public void visit(Table table)
        {
            tableCounter++;
        }

        public void visit(ImageProxy imageProxy)
        {
            imageCounter++;
        }

        internal void printStatistics()
        {
            Console.WriteLine("Book Statisitcs:\n" +
                $"*** Number of Images: {imageCounter}\n" +
                $"*** Number of Paragraphs: {paragraphCounter}\n" +
                $"*** Number of Tables: {tableCounter}\n");
        }
    }
}
