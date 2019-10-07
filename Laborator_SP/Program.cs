using Laborator_SP.Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_SP
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Titanic = new Book("Titanic");
            Author author = new Author("Raul Pavel");
            Titanic.addAuthor(author);
            int indexOfChapter = Titanic.createChapter("Chapter One");
            Chapter chapter = Titanic.getChapter(indexOfChapter);
            int indexOfSubChapter = chapter.createSubChapter("Chapter One-One");
            SubChapter subChapter = chapter.getSubChapter(indexOfSubChapter);
            int indexOfParagraph = subChapter.createParagraph("Paragraph one");
            int indexOfImage = subChapter.createImage("Image One");
            int indexOfTable = subChapter.createTable("Table One");

            Console.WriteLine(Titanic.Name);
            Console.ReadLine();
        }
    }
}
