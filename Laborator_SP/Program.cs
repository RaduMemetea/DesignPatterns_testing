using Laborator_SP.Clase;
using Laborator_SP.Clase.Elements;
using System;
using System.Diagnostics;

namespace Laborator_SP
{
    class Program
    {
        public static object StopWatch { get; private set; }

        static void Main(string[] args)
        {
            /*
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
            noapteBuna.Print();

            Console.WriteLine();

            Console.ReadKey();

*/

            /*
            Stopwatch watch = new Stopwatch();
            watch.Start();
            long startTime = 0;
            ImageProxy img1 = new ImageProxy("Pamela Anderson");
            ImageProxy img2 = new ImageProxy("Kim Kardashian");
            ImageProxy img3 = new ImageProxy("Kirby Griffin");

            Section playboyS1 = new Section("Front Cover");
            playboyS1.Add(img1);
            Section playboyS2 = new Section("Summer Girls");
            playboyS2.Add(img2);
            playboyS2.Add(img3);
            Book playboy = new Book("Playboy");
            playboy.addContent(playboyS1);
            playboy.addContent(playboyS2);

            long endTime = watch.ElapsedMilliseconds;
            Console.WriteLine("Creation of the content took " + (endTime - startTime) + " milliseconds");

            startTime = watch.ElapsedMilliseconds;
            playboyS1.print();
            endTime = watch.ElapsedMilliseconds;
            Console.WriteLine("Printing of the section 1 took " + (endTime - startTime) + " milliseconds");
            startTime = watch.ElapsedMilliseconds;
            playboyS1.print();
            endTime = watch.ElapsedMilliseconds;
            Console.WriteLine("Printing again the section 1 took " + (endTime - startTime) + " milliseconds");
            Console.ReadKey();
            */
            Section cap1 = new Section("Capitolul 1");
            Paragraph p1 = new Paragraph("Paragraph 1");
            cap1.add(p1);
            Paragraph p2 = new Paragraph("Paragraph 2");
            cap1.add(p2);
            Paragraph p3 = new Paragraph("Paragraph 3");
            cap1.add(p3);
            Paragraph p4 = new Paragraph("Paragraph 4");
            cap1.add(p4);
            Console.WriteLine("Printing without Alignment");
            Console.WriteLine();
            cap1.print();
            p1.setAlignStrategy(new AlignCenter());
            p2.setAlignStrategy(new AlignRight());
            p3.setAlignStrategy(new AlignLeft());
            Console.WriteLine();
            Console.WriteLine("Printing with Alignment");
            Console.WriteLine();
            cap1.print();
            Console.ReadKey();
        }
    }
}
