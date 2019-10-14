using System;

namespace Laborator_SP.Clase
{
    public class Image : Element
    {
        public Image(string name):base(name)
        {
        }

        public override void print()
        {
            Console.WriteLine("Image: {0}",Name);
        }
    }
}