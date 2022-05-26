using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
     class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Lütfen Müşteri bilgilerini giriniz");
            Console.WriteLine(musteri.Name+ " " + musteri.Surname);
            Console.WriteLine("Kayıt gerçekleşti");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi : " + musteri.Name + " " + musteri.Surname);
        }
    }
}
