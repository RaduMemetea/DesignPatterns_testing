using System;

namespace Laborator_SP.Clase
{
    public sealed class DefaulObserver : Observer
    {
        private static readonly DefaulObserver instance = new DefaulObserver();
        public static DefaulObserver Instance
        {
            get { return instance; }
        }
        private DefaulObserver() { }
        public void update(string oldValue, string newValue, string type)
        {
            Console.WriteLine("{0} [\n" +
                "OldValue: {1}\n" +
                "NewValue: {2}\n" +
                "]\n", type, oldValue, newValue);
        }
    }
}
