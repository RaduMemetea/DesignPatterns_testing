namespace Laborator_SP.Clase
{
    public class Author
    {
        public string Name { get; private set; }
        public Author() { }
        public Author(string name)
        {
            Name = name;
        }
    }
}