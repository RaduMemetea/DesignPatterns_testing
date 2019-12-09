using System;
using System.Collections.Generic;
using System.Threading;

namespace Laborator_SP.Clase
{
    public class Image : Element,Observable
    {
        public String Name { get; private set; }
        public String oldName { get; private set; }
        public Image(string name)
        {
            Name = name;
            Thread.Sleep(5);

            observerList.Add(DefaulObserver.Instance);
        }

        public void print()
        {
            Console.WriteLine("Image: {0}",Name);
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
                item.update(oldName, Name,"Image");
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
            return new Image(Name);
        }
    }
}