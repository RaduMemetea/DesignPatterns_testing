using System;
using System.Collections.Generic;

namespace Laborator_SP.Clase
{

    class Section : Element
    {
        private string Name { get; set; }
        private List<Element> Content { get; set; }

        public Section(String name)
        {
            Name = name;
            Content = new List<Element>();
        }
        public void add(Element element)
        {
            Content.Add(element);
        }
        public void Remove(Element element)
        {
            Content.Remove(element);
        }

        public Element getElement(int index)
        {
            return Content[index];
        }
        public void print()
        {
            Console.WriteLine("{0}",Name);
            foreach (var item in Content)
                item.print();
        }
    }
}
