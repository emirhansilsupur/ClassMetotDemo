using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Musteri musteri1 = new Musteri();
            
            musteri1.Ad = "Emir";
            musteri1.Soyad = "Silsüpür";
            musteri1.TckNo = "12345678901";
            musteri1.Yas = 23;
            musteri1.Telefon = "6656548722";

            Musteri musteri2 = new Musteri();
           
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Demir";
            musteri2.TckNo = "23654896451";
            musteri2.Yas = 44;
            musteri2.Telefon = "5454848858";

            Musteri musteri3 = new Musteri();
           
            musteri3.Ad = "Ahmet";
            musteri3.Soyad = "Çelik";
            musteri3.TckNo = "26589963454";
            musteri3.Yas = 35;
            musteri3.Telefon = "3565488484";

            Musteri musteri4 = new Musteri();
            
            musteri4.Ad = "Kemal";
            musteri4.Soyad = "Deniz";
            musteri4.TckNo = "15897445632";
            musteri4.Yas = 65;
            musteri4.Telefon = "1235545454";

            Musteri[] musteriler = new Musteri[]
            {musteri1, musteri2, musteri3, musteri4};

            //Müşteri ekleme

            MusteriYoneticisi musteriYoneticisi = new MusteriYoneticisi();

            musteriYoneticisi.Ekle(musteri1);
            musteriYoneticisi.Ekle(musteri2);
            musteriYoneticisi.Ekle(musteri3);
            musteriYoneticisi.Ekle(musteri4);

            //Müşteri listesi

            musteriYoneticisi.Listele(musteriler);

            //Müşteri kaydı silme

            musteriYoneticisi.Sil(musteri1);
            





        }
    }
}
