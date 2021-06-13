using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirci etiştirme Kampı";
            string kurs2 = "Proglamlamaya başlangıç için temel kurs";
            string kurs3 = "Java";



            string[] kurslar = new string[] { "Yazılım Geliştirci y etiştirme Kampı",
            "Proglamlamaya başlangıç için temel kurs","Java","Python","C#" };



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("For bitti");
            foreach (string kurs in kurslar)
            {

                Console.WriteLine(kurs);

            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}