using Laborator_SP.Clase;
using System;
using System.Collections;
using System.Collections.Generic;

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

        public Stack<Command> stackUndo { get; set; } = new Stack<Command>();
        public Stack<Command> stackRedo { get; set; } = new Stack<Command>();

    }
}
