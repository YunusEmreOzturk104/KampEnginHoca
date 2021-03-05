using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım geliştirici kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            // array dizilerde tutarız
            string[] kurslar = new string[] { "yazılım geliştirici kampı", "programlamaya başlangıç için temel kurs", "Java","phyton" };
            for (int i = 0; i <kurslar.Length; i++) 
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar) // diziler için kullanılır
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu-footer");
        }
    }
}
