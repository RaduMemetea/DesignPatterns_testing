using System;
using System.Collections.Generic;

namespace Laborator_SP.Clase
{
    public class SubChapter
    {
        public string Name { get; private set; }
        public List<Element> Elements { get; private set; }

        public SubChapter(string name)
        {
            Name = name;
            Elements = new List<Element>();
        }

        private void addParagraph(Paragraph paragraph)
        {
            Elements.Add(paragraph);
        }
        private void addTable(Table table)
        {
            Elements.Add(table);

        }
        private void addImage(Image image)
        {
            Elements.Add(image);
        }

        public int createParagraph(string ParagraphName)
        {
            Paragraph p = new Paragraph(ParagraphName);
            addParagraph(p);
            return Elements.IndexOf(p);
        }

        public void print()
        {
            Console.WriteLine("Subchapter: {0}",Name);
            foreach (var item in Elements)
                item.print();

        }

        public Paragraph getParagraph(int index)
        {
            int i = 0;
            foreach (var item in Elements)
                if(item is Paragraph)
                {
                    ++i;
                    if (i == index)
                        return (Paragraph)item;
                }
            return null;
        }
        public int createImage(string ImageName)
        {
            Image image = new Image(ImageName);
            addImage(image);
            return Elements.IndexOf(image);
        }
        public Image getImage(int index)
        {
            int i = 0;
            foreach (var item in Elements)
                if (item is Image)
                {
                    ++i;
                    if (i == index)
                        return (Image)item;
                }
            return null;
        }
        public int createTable(string TableName)
        {
            Table table = new Table(TableName);
            addTable(table);
            return Elements.IndexOf(table);
        }
        public Table getTable(int index)
        {
            int i = 0;
            foreach (var item in Elements)
                if (item is Table)
                {
                    ++i;
                    if (i == index)
                        return (Table)item;
                }
            return null;
        }

    }
}