using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            // Metotlar, belirli bir görevi yerine getiren kod bloklarıdır, Mor renkli küp gözükür.
            //Geriye değer döndürmeyen metotlar void ile tanımlanır.
            //Customer----> Listele, ekle, sil, güncelle
            //void MetotAdi(parametreler)

            //void CustomerList()
            //{
            //    Console.WriteLine("Enes Akkaya");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Murat Yücedağ");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x= 10;
            //    int y= 20;
            //    Console.WriteLine(x + y);
            //}

            //Sum();

            #endregion

            #region Değer Döndürmeyen Parametreli Metotlar

            //void Sum(int x, int y)
            //{
            //    Console.WriteLine(x + y);
            //}
            //Sum(10, 20);



            #endregion

            #region Değer Döndürmeyen string Parametreli Metotlar

            //void Sum(int x, int y, int z)
            //{
            //    int result;
            //    result= x + y + z;
            //    Console.WriteLine(result);
            //}

            //Sum(10, 20, 30);

            #endregion

            #region Geriye değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Enes";
            //    string surname = "Akkaya";

            //    return name + " " + surname;


            //}

            //Console.WriteLine(StudentCard());



            #endregion

            #region Geriye string ve int değer döndüren parametreli metotlar

            //int ToplamSayi(int x, int y, int z)
            //{
            //    int toplam = 0;
            //    toplam = x + y + z;
            //    return toplam;

            //}

            //Console.WriteLine(ToplamSayi(4, 5, 6));

            //string CountryCards(string CountryName, string Capital, string flagColor)
            //{
            //    string cardInfo = "Ülke adı: " + CountryName + ". Başkent adı: " + Capital + ". Ülke Bayrağı: " + flagColor;
            //    return cardInfo;
            //}

            //Console.Write("Ülke adını giriniz: ");
            //string x = Console.ReadLine();

            //Console.Write("Ülke başkentini giriniz: ");
            //string u = Console.ReadLine();

            //Console.Write("Ülke bayrak rengini giriniz: ");
            //string z = Console.ReadLine();

            //Console.WriteLine(CountryCards(x, u, z));

            #endregion


            Console.Read();
        }
    }
}
