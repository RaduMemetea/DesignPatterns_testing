using System.Collections.Generic;

namespace Laborator_SP.Clase
{
    public class Chapter
    {
        public string Name { get; private set; }
        public List<SubChapter> SubChapters { get; private set; }
        public Chapter(string name)
        {
            Name = name;
            SubChapters = new List<SubChapter>();
        }
        public void addSubChapter(SubChapter subChapter)
        {
            SubChapters.Add(subChapter);
        }
        public int createSubChapter(string SubChapterName)
        {
            SubChapter sub = new SubChapter(SubChapterName);
            addSubChapter(sub);
            return SubChapters.IndexOf(sub);
        }
        public SubChapter getSubChapter(int index)
        {
            return SubChapters[index];
        }
    }
}