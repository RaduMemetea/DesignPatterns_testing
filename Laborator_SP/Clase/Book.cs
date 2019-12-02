using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Laborator_SP.Clase
{
    class Book
    {
        public string Name { get; private set; }
        public List<Author> Authors { get; private set; }
        public List<Element> Sections { get; private set; }

        public Book(String name)
        {
            Name = name;
            Authors = new List<Author>();
            Sections = new List<Element>();
        }
        [JsonConstructor]
        public Book(String n, List<Author> a, List<Element> e)
        {
            Name = n;
            Authors = a;
            Sections = e;
        }
        public Book()
        {
        }

        public void addAuthor(Author author)
        {
            Authors.Add(author);
        }

        public void addContent(Element element)
        {
            Sections.Add(element);
        }
        public void addContent(params Element[] element)
        {
            Sections.AddRange(element);
        }
        public void Print()
        {
            Console.WriteLine("Book: {0}", Name);
            Console.WriteLine("Authors:");
            foreach (var item in Authors)
                Console.WriteLine("Author: {0}",item.Name);
            Console.WriteLine();

            foreach (var item in Sections)
                item.print();
        }
    }
}
