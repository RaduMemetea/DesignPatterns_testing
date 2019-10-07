using System.Collections.Generic;

namespace Laborator_SP.Clase
{
    public class SubChapter
    {
        public string Name { get; private set; }
        public List<Paragraph> Paragraphs { get; private set; }
        public List<Image> Images { get; private set; }
        public List<Table> Tables { get; private set; }

        public SubChapter(string name)
        {
            Name = name;
            Paragraphs = new List<Paragraph>();
            Images = new List<Image>();
            Tables = new List<Table>();
        }

        private void addParagraph(Paragraph paragraph)
        {
            Paragraphs.Add(paragraph);
        }
        private void addTable(Table table)
        {
            Tables.Add(table);
        }
        private void addImage(Image image)
        {
            Images.Add(image);
        }

        public int createParagraph(string ParagraphName)
        {
            Paragraph p = new Paragraph(ParagraphName);
            addParagraph(p);
            return Paragraphs.IndexOf(p);
        }
        public Paragraph getParagraph(int index)
        {
            return Paragraphs[index];
        }
        public int createImage(string ImageName)
        {
            Image image = new Image(ImageName);
            addImage(image);
            return Images.IndexOf(image);
        }
        public Image getImage(int index)
        {
            return Images[index];
        }
        public int createTable(string TableName)
        {
            Table table = new Table(TableName);
            addTable(table);
            return Tables.IndexOf(table);
        }
        public Table getTable(int index)
        {
            return Tables[index];
        }

    }
}