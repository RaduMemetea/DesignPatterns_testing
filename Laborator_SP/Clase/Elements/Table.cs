using System;
using System.Collections.Generic;

namespace Laborator_SP.Clase
{
    public class Table : Element, Observable
    {
        public String Name { get; private set; }
        public String oldName { get; private set; }

        public Table(string name)
        {
            Name = name;
            observerList.Add(DefaulObserver.Instance);
        }

        public void print()
        {
            Console.WriteLine("Table: {0}", Name);
        }

        public void accept(Visitor visitor)
        {
            visitor.visit(this);
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
                item.update(oldName, Name,"Table");
            }

        }

        public void setNewValue(string newValue)
        {
            oldName = Name;
            Name = newValue;
            notifyObservers();
        }

        public Element copy()
        {
            return new Table(Name);
        }
    }
}