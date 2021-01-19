using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriYoneticisi
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad +" " + musteri.Soyad + " TCKNO : " + musteri.TckNo + ", Yaşı : " + musteri.Yas + ", Telefon numarası : " + musteri.Telefon + " Müşteri kayıt edildi.");
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach(Musteri musteri in musteriler)
            {
                
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.Soyad);
                Console.WriteLine(musteri.TckNo);
                Console.WriteLine(musteri.Yas);
                Console.WriteLine(musteri.Telefon);
            }

        } 

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + musteri.TckNo + " " + musteri.Yas + " " + musteri.Telefon + " Müşteri kaydı silinmiştir.");
        }
    }
}
