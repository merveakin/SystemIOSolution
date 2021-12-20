using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryConsole_AppOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********HOŞGELDİNİZ**********");
            //C klasörü içine kendi adınızla bir klasör oluşturmanız isteniyor.
            Console.WriteLine("Dosyanızın adını ne koymak isterdiniz...");
            string myPath = Console.ReadLine();
            string myFile = $"C:\\{myPath}";

            KlasorOlusturma(myFile);

            if (KlasordenVarMi(myFile))
            {
                Console.WriteLine($"{myFile} dosyanız zaten oluşmuş işleminize devam ediniz...");
            }

            else   
            {
                KlasorOlusturma(myFile);
                Console.WriteLine("Hali Hazırda istediğiniz dosya yoktu.. Ama dert etmeyin ben oluşturdum... :)");
            }

            Baslangic:

            Console.WriteLine("Hangi işlemi yapmak istersiniz ? \n" +
                "1 --> Klasörü Taşı \n"+
                "2 --> Klasörü Sil");

            try
            {
                int tercih = Convert.ToInt32(Console.ReadLine());

                switch (tercih)
                {
                    case 1:
                        Console.WriteLine("Klasörü taşımak istediğinize emin misiniz? E/H ?");
                        ConsoleKeyInfo secimTasi = Console.ReadKey();
                        if (secimTasi.Key == ConsoleKey.E)
                        {
                            Console.WriteLine("Taşınacak dosyanın adını giriniz...");
                            string postFile = Console.ReadLine();

                            KlasoruTasi(myFile, $"C:\\{postFile}");
                        }
                        else if (secimTasi.Key == ConsoleKey.H)
                        {
                            Console.WriteLine("Hayır'a tıkladınız. Lütfen devam ediniz.");
                            goto Baslangic;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir seçim yapınız.");
                            goto Baslangic;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Klasörü silmek istediğinize emin misiniz ? E/H ?");
                        ConsoleKeyInfo secimSil = Console.ReadKey();
                        if (secimSil.Key == ConsoleKey.E)
                        {
                            KlasoruSil(myFile);
                        }
                        else if (secimSil.Key == ConsoleKey.H)
                        {
                            Console.WriteLine("Hayır'a tıkladınız. Lütfen devam ediniz.");
                            goto Baslangic;
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir seçim yapınız.");
                            goto Baslangic;
                        }
                        break;


                    default:
                        Console.WriteLine("Lütfen geçerli işlem yapınız...");
                        break;
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("HATA : GEÇERLİ İŞLEM YAPINIZ... PROGRAMI PATLATMAYALIM ARKADAŞLAR BİRAZ DİKKAT..." + ex.Message);
            }


            //Kullanıcıya klasörü sil -- 1 Klasörü Taşı -- 2 gibi menü sunmanız isteniyor.
            //Kullanıcı hangi işlemi seçerse o işlem yapılacaktır.
            //Silme işlemini seçerse Emin Misiniz? E/H sorusu sormanız ve verilecek cevaba göre silme işlemi yapmanız isteniyor.

            Console.ReadKey();
        }

        private static void KlasorOlusturma(string File)
        {
            DirectoryInfo dosyam = Directory.CreateDirectory(File);
        }

        private static void KlasoruSil(string File)
        {
            Directory.Delete(File);
            Console.WriteLine($"Silmek istediğiniz {File} dosyası silindi.");
        }

        private static void KlasoruTasi(string gidecekFile, string hedefFile)
        {
            Directory.Move(gidecekFile, hedefFile);
            Console.WriteLine($"{hedefFile} dosyasına taşımak istediğiniz {gidecekFile} dosyasının taşıma işlemi tamamlandı.");
        }
        private static bool KlasordenVarMi(string File)
        {
            bool sonuc = false;
            sonuc = Directory.Exists(File);
            return sonuc;
        }
    }
}
