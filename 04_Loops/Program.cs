using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Döngüler For Döngüsü

            //Döngüler 1+2+3+4+5+6 şeklinde normal toplanır
            //programlama 1+2=3+3=6+4=10+5=15+6=21 şeklinde toplar

            //1. For Döngüsü For(x;y;z)
            //x: başlangıç değeri
            //y: bitiş
            //z: artış: azalış

            //int i;

            //for(i=1;i<=5;i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for(i=1;i<=20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalValue = 0;
            //for (int i = 0; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue= 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //         totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-------");
            //Console.WriteLine(totalValue);


            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //        Console.WriteLine(i + " Sayısı 7 ile tam bölünür. 7 ile bölünen " + count + ".sayı");

            //    }

            //}
            //Console.WriteLine("");
            //Console.WriteLine("7 ile bölünen toplam sayı: " + count);


            //24 saatte kaç bakteri olduğunu hesaplayan programı yaz

            //int bakteriSayisi=1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteriSayisi= bakteriSayisi * 2;
            //    Console.WriteLine("1.Saatin sonunda bakteri sayısı: "+ bakteriSayisi);
            //}
            //Console.WriteLine();
            //Console.WriteLine(bakteriSayisi);

            #endregion

            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}


            //int i = 0;

            //while (i <= 100)
            //{
            //    i++;
            //    if (i % 3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int i = 1;
            //int result = 0;
            //while (i <= 10)
            //{

            //     result = result + i;
            //    i++;
            //}
            //Console.WriteLine(result);

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen üç basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.

            //int sayi = 0;
            //Console.WriteLine("Üç basamaklı sayı girişi: ");
            //sayi = int.Parse(Console.ReadLine());

            //int birlerBasamagi;
            //int onlarBasamagi;
            //int yuzlerBasamagi;


            //if (sayi % 100 == 0)
            //{
            //    yuzlerBasamagi = sayi / 100;

            //    Console.WriteLine("Sayının yüzler basamağı " + yuzlerBasamagi + "onlar ve  birler basamağı ");
            //}
            //else if (sayi % 100 != 0)
            //{

            //}

            //Klavyeden girilen üç basamaklı sayının basamakları toplamını hesaplayan kodu yazınız. deneme 2

            int sayi = 0;
            Console.WriteLine("Üç basamaklı sayı girişi: ");
            sayi = int.Parse(Console.ReadLine());

            int birlerBasamagi;
            int onlarBasamagi;
            int yuzlerBasamagi;
            yuzlerBasamagi = sayi / 100;
            onlarBasamagi = sayi / 10;
            onlarBasamagi = onlarBasamagi % 10;
            birlerBasamagi = sayi % 10;

            Console.WriteLine("Verdiğiniz sayının;");
            Console.WriteLine("Birler basamağı: "+birlerBasamagi);
            Console.WriteLine("Onlar basamağı: "+onlarBasamagi);
            Console.WriteLine("Yüzler basamağı: "+yuzlerBasamagi);


            #endregion

            Console.Read();
        }
    }
}
