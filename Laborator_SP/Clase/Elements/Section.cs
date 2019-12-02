using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Laborator_SP.Clase
{

    class Section : Element, Observable
    {
        public string Name { get; private set; }
        public String oldName { get; private set; }
        public List<Element> Content { get; private set; }

        public Section(String name)
        {
            Name = name;
            Content = new List<Element>();

            observerList.Add(DefaulObserver.Instance);
        }

        [JsonConstructor]
        public Section(String name, List<Element> list)
        {
            Name = name;
            Content = list;
        }

        public Section()
        {
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
            Console.WriteLine("{0}", Name);
            foreach (var item in Content)
                item.print();
        }

        public void accept(Visitor visitor)
        {
            foreach (var item in Content)
            {
                item.accept(visitor);
            }
        }
        List<Observer> observerList = new List<Observer>();
        public void addObserver(Observer obs)
        {
            observerList.Add(obs);
        }

        public void removeObserver(Observer obs)
        {
            observerList.Remove(obs);
        }

        public void notifyObservers()
        {
            foreach (var item in observerList)
            {
                item.update(oldName, Name, "Section");
            }

        }

        public void setNewValue(string newValue)
        {
            oldName = Name;
            Name = newValue;
            notifyObservers();
        }

    }
}
