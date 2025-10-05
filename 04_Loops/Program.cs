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

            int totalValue= 0;
            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                     totalValue += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("-------");
            Console.WriteLine(totalValue);
            #endregion

            Console.Read();
        }
    }
}
