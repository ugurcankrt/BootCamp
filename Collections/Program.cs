using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] isimler = new string[] {"Uğurcan","Engin","Serhat" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);

            //isimler = new string[4];
            //isimler[3] = "Messi";
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[1]);


            List<string> isimler2 = new List<string> { "Uğurcan", "Engin", "Serhat" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Messi");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);





        }
    }
}
