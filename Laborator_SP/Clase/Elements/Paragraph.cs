using System;

namespace Laborator_SP.Clase
{
    public class Paragraph : Element
    {
        protected String Name { get; set; }
        private AlignStrategy align;

        public Paragraph(string name)
        {
            Name = name;
        }

        public void Print()
        {
            if(align!=null)
               align.print(Name);
            else
               Console.WriteLine("Paragraph: {0}", Name);
        }
        public setAlignStrategy(AlignStrategy Al)
        {
            align =Al;
        }
    }
}
