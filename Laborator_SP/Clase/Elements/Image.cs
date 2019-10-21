using System;

namespace Laborator_SP.Clase
{
    public class Image : Element
    {
        protected String Name { get; set; }
        public Image(string name)
        {
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine("Image: {0}",Name);
        }
    }
}