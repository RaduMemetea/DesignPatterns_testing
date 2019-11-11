using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_SP.Clase
{
    public interface Visitor
    {
        public void visit(Image image);
        public void visit(ImageProxy imageProxy);
        public void visit(Paragraph paragraph);
        public void visit(Table table);
    }
}
