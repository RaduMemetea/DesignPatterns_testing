using System;

namespace Laborator_SP.Clase
{
    public class Paragraph:Element
    {
        public Paragraph(string name):base(name)
        {
        }

        public override void print()
        {
            Console.WriteLine("Paragraph: {0}",Name);
        }
    }
}