using System;

namespace Laborator_SP.Clase
{
    public class Paragraph : Element
    {
        protected String Name { get; set; }

        public Paragraph(string name)
        {
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine("Paragraph: {0}", Name);
        }
    }
}