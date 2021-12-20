using System;
using System.IO;

namespace SystemIODirectoryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string myPath = @"C:\NetworkAkademi103";
            //ya da string myPath = "C:\\NetworkAkademi103";

            //if ile dosyanın var oluşunu kontrol edelim.
            if (KlasordenVarMi(myPath))
            {
                Console.WriteLine($"{myPath} dosya yolu zaten oluşmuş.");
            }

            else    //false dönmüş demektir.Directory'nin oluşması için metodu çağıralım.
            {
                YeniKlasorOlustur(myPath);
            }

            Console.WriteLine();


            //KlasoruSil(myPath);
            //Console.WriteLine($"{myPath} directory silindi.");

            //Taşıma işlemi
            
            KlasoruTasi(myPath, "C:\\Merve1212");



            //YeniKlasorOlustur(myPath);


            Console.ReadKey();
        }

        private static void YeniKlasorOlustur(string dosyaYolu)
        {
            DirectoryInfo di = Directory.CreateDirectory(dosyaYolu);
        }

        private static bool KlasordenVarMi(string dosyaYolu)
        {
            bool sonuc = false;

            sonuc = Directory.Exists(dosyaYolu);
            return sonuc;
        }

        //private static void KlasoruSil(string dosyaYolu)
        //{
        //    Directory.Delete(dosyaYolu);
        //}

        private static void KlasoruTasi(string KaynakYol, string HedefYol)
        {
            //Dirctory.Move(source,dest) 
            //NOT: dest yolunu metot içeride kendisi oluşturuyor.
            Directory.Move(KaynakYol, HedefYol);
            Console.WriteLine($"Kaynak : {KaynakYol}, {HedefYol} hedefine taşındı...");
        }
    }
}
