using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOWindowFormApp
{
    public class Personel
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Email { get; set; }
        public string Firma { get; set; }
        public string Ulke { get; set; }

        public override string ToString()
        {
            return this.Isim + " " + this.Soyisim;
        }

        public string PersonelDetayBilgisiGetir()
        {
            string detaylar = string.Empty;

            detaylar = $"{this.Isim} {this.Soyisim} adlı kişinin detay bilgileri aşağıdaki gibidir.\n " + $"Çalıştığı Firma : {this.Firma} \n" + $"İletişim : {this.Email}";

            return detaylar;
        }
    }
}
