using System;

namespace Laborator_SP.Clase
{
    public class Table:Element
    {
        public Table(string name):base(name)
        {
        }

        public override void print()
        {
            Console.WriteLine("Table: {0}",Name);
        }
    }
}