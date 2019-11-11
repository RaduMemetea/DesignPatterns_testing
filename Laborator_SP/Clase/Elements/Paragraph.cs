using System;

namespace Laborator_SP.Clase
{
    public class Paragraph : Element
    {
        protected String Name { get; set; }
        private AlingnStrategy alingn;

        public Paragraph(string name)
        {
            Name = name;
        }

        public void print()
        {
            if (alingn == null)
                Console.WriteLine($"Paragraph: {Name}");
            else
                alingn.print(Name);
        }
        public void setAlignStrategy(AlingnStrategy alingn)
        {
            this.alingn = alingn;
        }

        public void accept(Visitor visitor)
        {
            visitor.visit(this);
        }
    }
}