using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
             


            IKrediManager tasitKrediManager = new TasitKrediManager();
             


            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoglamaServisi veritabanınaLoglamaServisi = new VeritabanıLoglamaServisi();
            ILoglamaServisi dosyayaLoglamaServisi = new DosyaLoglamaServisi();

            
            
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoglamaServisi> {dosyayaLoglamaServisi, veritabanınaLoglamaServisi });
             
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, konutKrediManager };
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


                            
        }
    }
}
