using System;
using System.Threading;

namespace Laborator_SP.Clase
{
    public class Image : Element
    {
        protected String Name { get; set; }
        public Image(string name)
        {
            Name = name;
            Thread.Sleep(5000);
        }

        public void print()
        {
            Console.WriteLine("Image: {0}",Name);
        }
    }
}