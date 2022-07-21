using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string adi = "Engin";
            int yas = 36;

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.kursEgitmeni = "Uğurcan KURT";
            kurs1.izlenmeOrani = 13;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "C#";
            kurs2.kursEgitmeni = "Serhat ÖZDEMİR";
            kurs2.izlenmeOrani = 10;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "C#";
            kurs3.kursEgitmeni = "Engin TOPRAK";
            kurs3.izlenmeOrani = 80;

            Kurs kurs4 = new Kurs();
            kurs4.kursAdi = "C#";
            kurs4.kursEgitmeni = "Sergin Kurttoprak";
            kurs4.izlenmeOrani = 50;


            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3, kurs4};

            foreach (Kurs kursdizi in kurslar)
            {
                Console.WriteLine(kursdizi.kursAdi+" : "+kursdizi.kursEgitmeni+" = "+kursdizi.izlenmeOrani);
            }


            


        }
    }

    class Kurs
    {

        public string kursAdi { get; set; }

        public string kursEgitmeni { get; set; }

        public int izlenmeOrani { get; set; }
    }        


}


