using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri gercekMusteri1 = new GercekMusteri();
            gercekMusteri1.Id = 1;
            gercekMusteri1.MusteriNo = "12345";
            gercekMusteri1.Adi = "Uğurcan";
            gercekMusteri1.Soyadi = "KURT";
            gercekMusteri1.TcNo = "11111111111";

            TuzelMusteri tuzelMusteri1 = new TuzelMusteri();
            tuzelMusteri1.Id = 2;
            tuzelMusteri1.MusteriNo = "123";
            tuzelMusteri1.SirketAdi = "Kurt Taşımacılık";
            tuzelMusteri1.VergiNo = "123456";


            Musteri musteri2 = new GercekMusteri();
            Musteri musteri3 = new TuzelMusteri();


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(gercekMusteri1);
            musteriManager.Ekle(tuzelMusteri1);
            musteriManager.Ekle(musteri2);








        }
    }
}
