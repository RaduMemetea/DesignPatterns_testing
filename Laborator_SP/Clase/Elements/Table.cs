using System;

namespace Laborator_SP.Clase
{
    public class Table : Element
    {
        protected String Name { get; set; }

        public Table(string name)
        {
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine("Table: {0}", Name);
        }
    }
}