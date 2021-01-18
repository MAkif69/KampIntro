using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Programlama başlangıç için temel kurs", "Java"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa sonu - footer");

            //for (int i = 0; i < 10; i += 2)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
