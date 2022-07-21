using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";


            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", 
                "Programlamaya başlangıç için temel kurs", "Java", "Python", "C#" };
            

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitimi");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu");
            Console.WriteLine("while döngüsü nedir");

            int i1 = 0;
            while (i1<10)
            {
                Console.WriteLine("Uğurcan" +" "+"Kurt");
                i1 =i1 + 1;
            }
            


        }
    }
}
