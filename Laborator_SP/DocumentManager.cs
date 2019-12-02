using Laborator_SP.Clase;
using System;

namespace Laborator_SP
{
    public sealed class DocumentManager
    {
        Book book;
        private static readonly DocumentManager instance = new DocumentManager();
        public static DocumentManager Instance
        {
            get { return instance; }
        }


        private DocumentManager()
        {

        }

        internal Book getBook()
        {
            return book;
        }
        internal void setBook(Book v)
        {
            book = v;
            
        }
    }
}
