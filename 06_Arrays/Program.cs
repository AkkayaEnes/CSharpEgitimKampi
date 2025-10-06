using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri - Array Yapısı

            //3 6 9 12 15 18 21 çift sayılar bir dizi örneğidir.
            //Bursa, Eskişehir, Ankara gibi.

            //DeğişkenTürü[] DiziAdı= new DeğişkenTürü[ElemanSayısı]

            //string[] colors = new string[4];
            //colors[0] = "Mavi";
            //colors[1] = "Beyaz";
            //colors[2] = "Sarı";
            //colors[3] = "Siyah";

            //Console.WriteLine(colors[3]);


            //string[] cities = new string[5];
            //cities[0] = "Ankara";
            //cities[1] = "İstanbul";
            //cities[2] = "Bursa";
            //cities[3] = "Eskişehir";
            //cities[4] = "Bolu";

            //for (int i = 0; i < cities.Length; i++) { 
            //    Console.WriteLine(cities[i]);
            //}


            //string[] names = { "Enes", "Nur", "Alperen", "Mehmethan", "Eray" };

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //char[] symbols = { 'a', 'b', 'c' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] sayilar = { 31, 223, 413, 419, 645, 766, 327, 38, 329 };

            //int maxNumber = sayilar[0];

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    if (sayilar[i] > maxNumber)
            //    {
            //        maxNumber = sayilar[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //küçükten
            //Array.Sort(sayilar);
            //for (int i = 0;i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}


            //tersten
            //Array.Reverse(sayilar);
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            #endregion

            #region Dizi Metodları

            //string[] customers = { "Nur", "Enes", "Mehmet", "Alperen", "Eray" };
            //int index = Array.IndexOf(customers, "Eray");
            //Console.WriteLine(index);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine("Dizinin en büyük elemanı: "+ numbers.Max());


            #endregion

            #region Kullanıcıdan değer alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i + 1}. Şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}





            #endregion

            Console.Read();
        }
    }
}
