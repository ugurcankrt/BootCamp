using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";
            urun1.StokAdedi = 12;

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Armut";
            urun2.Fiyati = 19;
            urun2.Aciklama = "Sulu sulu";
            urun2.StokAdedi = 24;
            
            Urun[] urunler = new Urun[] { urun1, urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Id);
                Console.WriteLine(urun.Adi);
                Console.WriteLine( urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }

            Console.WriteLine("---------Metotlar----------");


            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //farklı sayfa aşağıda bulunan kodlar
            sepetManager.Ekle2("Ceviz", "Taze", 100, 1);
            
            sepetManager.Ekle2("Ceviz", "Taze", 100, 1);
            
            sepetManager.Ekle2("Ceviz", "Taze", 100, 1);



        }
    }
}
