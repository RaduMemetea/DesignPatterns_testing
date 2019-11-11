namespace Laborator_SP.Clase
{
    public interface Element
    {
        public void print();
        public void accept(Visitor visitor);
    }
}