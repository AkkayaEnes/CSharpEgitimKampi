using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            // Foreach (1;2;3;4)

            //1:Değişken türü
            //2: Değişken Adı,
            //3:In
            //4: Lsite, Koleksiyon, Dizi

            #endregion


            //string[] cities = { "roma", "budapeşte", "İzmir", "Eskişehir", "Ağrı" };

            //foreach (string citys in cities)
            //{
            //    Console.WriteLine(citys);
            //}


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int toplam = 0;
            //foreach (var item in numbers)
            //{
            //    toplam+= item;
            //}

            //Console.WriteLine("Toplam: " + toplam);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,9
            //};

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //string word="Merhaba";

            //foreach(char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            //Klavyeden öğrenci sayısı notları ve ortalamaları değişken dizi döngü karar yapsını foreach ile yapalım.

            #region Örnek Sınav Sistemi

            Console.Write("******* C# Eğitim kampı sınav uygulaması *******\n\n");
            Console.Write("Lütfen öğrenci sayısını giriniz: ");
            int ogrenciSayisi = int.Parse(Console.ReadLine());

            string[] ogrenciIsımleri = new string[ogrenciSayisi];
            double[] ogrenciSinavOrt= new double[ogrenciSayisi];

            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.Write($"{i+1}. Öğrencinin ismini giriniz: ", i + 1);
                ogrenciIsımleri[i] = Console.ReadLine();

                double toplamSinavSonuc=    0;

                //her öğreci için 3 sınav notu girişi

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{ogrenciIsımleri[i]} adlı öğrencinin {j+1}. Sınav notunu giriniz: ");
                    double sinavNotu = double.Parse(Console.ReadLine());
                    toplamSinavSonuc += sinavNotu; //notları toplama
                }

                ogrenciSinavOrt[i] = toplamSinavSonuc / 3;

            }

            //Öğrencilerin ortalaması ve geçip kalma durumları

            for (int i = 0; i < ogrenciSayisi; i++)
            {
                Console.WriteLine($"\n{ogrenciIsımleri[i]} adlı öğrencinin sınav ortalaması: {ogrenciSinavOrt[i]}");
                if (ogrenciSinavOrt[i] >= 50)
                {
                    Console.WriteLine("Tebrikler, geçtiniz!");
                }
                else
                {
                    Console.WriteLine("Maalesef kaldınız.");
                }
            }



            #endregion

            Console.Read();

        }
    }
}
