using System;
using System.Collections.Generic;

namespace Laborator_SP.Clase
{
    public class Paragraph : Element, Observable
    {
        public String Name { get; private set; }
        public String oldName { get; private set; }
        private AlingnStrategy alingn;

        public Paragraph(string name)
        {
            Name = name;

            observerList.Add(DefaulObserver.Instance);
        }

        public void print()
        {
            if (alingn == null)
                Console.WriteLine($"Paragraph: {Name}");
            else
                alingn.print(Name);
        }
        public void setAlignStrategy(AlingnStrategy alingn)
        {
            this.alingn = alingn;
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
                item.update(oldName, Name,"Paragraph");
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