using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOFileConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool theFileisExists = false;
            theFileisExists = File.Exists("C:\\MerveAkin\\Merhaba.txt");
            if (!theFileisExists)
            {
                FileCreate("C:\\MerveAkin\\Merhaba.txt");
            }
            else
            {
                Console.WriteLine("Merhaba.txt dosyası sistemde bulunuyor.");
            }

            Console.WriteLine("Dosya içine yazılacak metni giriniz...");
            Console.WriteLine();
            string metin = Console.ReadLine();
            FileAppendTheText("C:\\MerveAkin\\Merhaba.txt", metin);


            ////////////////////////////

            Console.WriteLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;

            /////////////////////
            Console.WriteLine("Dosyanızı kopyalıyoruz...");
            FileCopy("C:\\MerveAkin\\Merhaba.txt", "C:\\MerveAkin\\Merhaba-Copy.txt");

            Console.WriteLine();

            Console.WriteLine("Dosyanızı taşıyoruz...");
            FileMove("C:\\MerveAkin\\Merhaba.txt", "C:\\MRV\\Merhaba.txt");

            /////////////////////
            Console.WriteLine("Merhaba.txt metin belgesini silmek istediğinize emin misiniz?");

            ConsoleKeyInfo cevap;
            cevap = Console.ReadKey();

            if (cevap.Key == ConsoleKey.E)
            {
                FileDelete("C:\\MerveAkin\\Merhaba.txt");
                Console.WriteLine("Silme işleminiz tamamlandı...");
            }

            else if (cevap.Key == ConsoleKey.H)
            {
                Console.WriteLine("Silmedik...");
            }

            else
            {
                Console.WriteLine("Soruya geçerli bir cevap vermediniz...");
            }


            Console.ReadKey();
        }

        private static void FileCreate(string path)
        {
            //FileStream --Dosya Aktarım
            FileStream fs = File.Create(path);
            fs.Close();

        }

        private static void FileAppendTheText(string path, string text)
        {
            File.AppendAllText(path, text);
        }

        private static void FileDelete(string path)
        {
            //File.Delete("C:\\MerveAkin\\Merhaba.txt");
            File.Delete(path);
        }

        private static void FileCopy(string sourceFile, string destFile)
        {
             // File.Copy(sourceFile, destFile);

            // Will overwrite if the destination file already exists.
                 File.Copy(sourceFile, destFile, true);
            // eğer overWrite parametresi true olarak verilirse var olan bir dosyaya kopyalama yapabilir.

            //Eğer overWrite parametresi false verilirse kendisinin oluşturması için bir dosya ismi destFile'a verilir.
            //File.Copy(sourceFile, destFile, false);
        }
        private static void FileMove(string sourceFile, string destFile)
        {
            File.Move(sourceFile, destFile);
        }


    }
}
