using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator_SP.Clase
{
    internal class OpenCommand : Command
    {
        Book book = null;
        public OpenCommand(string v)
        {

        }

        public void execute()
        {
            ttt();
            DocumentManager.Instance.setBook(book);
        }
        void ttt()
        {
            Book noapteBuna = new Book("Noapte buna, copii!");
            Author author = new Author("Radu Pavel Gheo");
            noapteBuna.addAuthor(author);

            Section cap1 = new Section("Chapter 1");
            Section cap11 = new Section("Chapter 1.1");
            Section cap111 = new Section("Chapter 1.1.1");
            Section cap1111 = new Section("SubChapter 1.1.1.1.1");

            noapteBuna.addContent(new Paragraph("Paragraph 1"),
                                    cap1,
                                    new Paragraph("Paragraph 2"),
                                    cap11,
                                    new Paragraph("Paragraph 3"),
                                    cap111,
                                    new Paragraph("Paragraph 4"),
                                    cap1111,
                                    new Image("Image 1"));
            book = noapteBuna;
        }
    }
}
