namespace Laborator_SP.Clase
{
    public abstract class Element
    {
        public string Name { get; private set; }
        public Element(string Name)
        {
            this.Name = Name;
        }
        abstract public void print();
    }
}