namespace Laborator_SP.Clase
{
    public interface Element
    {
        public void print();
        public void accept(Visitor visitor);
        public void setNewValue(string newValue);
        public Element copy();
    }
}