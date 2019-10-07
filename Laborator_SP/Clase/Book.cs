using System;
using System.Collections.Generic;

namespace Laborator_SP.Clase
{
    class Book
    {
        public string Name { get; private set; }
        public List<Author> Authors { get; private set; }
        public List<Chapter> Chapters { get; private set; }

        public Book(String name)
        {
            Name = name;
            Authors = new List<Author>();
            Chapters = new List<Chapter>();
        }
        public void addAuthor(Author author)
        {
            Authors.Add(author);
        }
        private void addChapter(Chapter chapter)
        {
            Chapters.Add(chapter);
        }

        public int createChapter(string ChapterName)
        {
            Chapter chapter = new Chapter(ChapterName);
            addChapter(chapter);
            return Chapters.IndexOf(chapter);
        }
        public Chapter getChapter(int index)
        {
            return Chapters[index];
        }
    }
}
