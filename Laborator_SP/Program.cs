using Laborator_SP.Clase;
using Newtonsoft.Json;
using System;
using System.IO;

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
            /*
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
            */
            /*
            Section cap1 = new Section("Capitolul 1");
            Paragraph p1 = new Paragraph("Paragraph 1");
            cap1.add(p1);
            Paragraph p2 = new Paragraph("Paragraph 2");
            cap1.add(p2);
            Paragraph p3 = new Paragraph("Paragraph 3");
            cap1.add(p3);
            Paragraph p4 = new Paragraph("Paragraph 4");
            cap1.add(p4);
            cap1.add(new ImageProxy("ImageOne"));
            cap1.add(new Image("ImageTwo"));
            cap1.add(new Paragraph("Some text"));
            cap1.add(new Table("Table 1"));
            BookStatistics stats = new BookStatistics();
            cap1.accept(stats);
            stats.printStatistics();
            FinancialBook finalBook = new FinancialBook();
            cap1.accept(finalBook);
            finalBook.getStatisitcs();
            */
            /*
            Command cmd1 = new OpenCommand("book.json");
            cmd1.execute();
            Command cmd2 = new StatisticsCommand();
            cmd2.execute();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            DocumentManager.Instance.getBook().Print();
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
            cap1.add(new ImageProxy("ImageOne"));
            cap1.add(new Image("ImageTwo"));
            cap1.add(new Paragraph("Some text"));
            cap1.add(new Table("Table 1"));


            cap1.setNewValue("CHAPTER 1");
            p1.setNewValue("PARAGRAPH 2");
            p2.setNewValue("PARAGRAPH 3");
            
            cap1.setNewValue("CHAPTER 1.1");


            Console.ReadKey();

        }

        private static void deserialize(ref Book b)
        {
            string jsondata = "";

            FileInfo saveFile = new FileInfo(@"D:\test.txt");
            FileStream fs = saveFile.Open(FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sw = new StreamReader(fs);
            jsondata = sw.ReadToEnd();
            sw.Close();
            fs.Close();


            if (jsondata != "")
            {

                try
                {
                    // s = JsonConvert.DeserializeObject<Section>(jsondata);
                    var v = JsonConvert.DeserializeObject<object>(jsondata, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });


                }
                catch (Exception)
                {

                    throw;
                }
            }



        }

        static void serialize(Book book)
        {
            FileInfo saveFile = new FileInfo(@"D:\test.txt");
            FileStream fs = saveFile.Open(FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
            StreamWriter sw = new StreamWriter(fs);
            var jsondata = JsonConvert.SerializeObject(book, Formatting.Indented, new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });
            sw.Write(jsondata);
            sw.Close();
            fs.Close();
        }
    }
}
