using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Karar Yapıları IF ELSE


            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru!");

            //}
            //else {

            //    Console.WriteLine("Şifre Yanlış :(");

            //}


            //string capital, country;

            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //    country = Console.ReadLine();

            //if (country == "Türkiye" & capital == "Ankara")
            //{
            //    Console.WriteLine("Bilgiler doğru!");

            //}
            //else {
            //    Console.WriteLine("Bilgiler yanlış");
            //}


            //int number;
            //Console.Write("Sayı gir: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 12)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}

            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}



            //int exam1, exam2, exam3, exam4, average;
            //string result= "Hata!";

            //Console.Write("Sınav 1 Sonucu: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2 Sonucu: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3 Sonucu: ");
            //exam3 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 4 Sonucu: ");
            //exam4 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3 + exam4) / 4;

            //if (average >= 0 & average <= 25)
            //{
            //    result = "Başarısız";
            //}
            //if (average >= 26 & average <= 49)
            //{
            //    result = "Kötü";
            //}
            //if (average >= 50 & average <= 74)
            //{
            //    result = "İyi";
            //}
            //if (average >= 75 & average <= 100)
            //{
            //    result = "Çok iyi";
            //}

            //Console.Write(result);


            //string sehir;
            //Console.WriteLine("Lütfen şehiri giriniz: ");
            //sehir = Console.ReadLine();

            //if (sehir == "Ankara" | sehir == "Bursa")
            //{
            //    Console.WriteLine("Şehir doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir yanlış!");
            //}

            //string userName;
            //Console.WriteLine("Kullanıcı adı giriniz: ");
            //userName = Console.ReadLine();

            //if (userName != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı giremez");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz");
            //}



            #endregion

            #region Mod İşlemleri

            //int a, b;

            //Console.WriteLine("Birinci sayıyı giriniz: ");
            //a = int.Parse(Console.ReadLine());

            //Console.WriteLine("ikinci sayıyı giriniz: ");
            //b = int.Parse(Console.ReadLine());

            //int result = a % b;
            //Console.WriteLine(result);

            #endregion

            #region Char İşlemleri

            //char takim;

            //Console.WriteLine("Lütfen takımın ilk harfini giriniz: ");
            //takim = char.Parse(Console.ReadLine());

            //if(takim == 'g' | takim == 'G')
            //{

            //    Console.WriteLine("Takım Galatasaray!");

            //}
            //else if (takim == 'b' | takim == 'B')
            //{

            //    Console.WriteLine("Takım Beşiktaş!");

            //}
            //else if(takim == 'f' | takim == 'F')
            //{

            //    Console.WriteLine("Takım Fenerbahçe!");

            //}
            //else
            //{
            //    Console.WriteLine("Takım Yanlış!");
            //}


            #endregion

            #region Örnek Proje Uygulaması

            //int menu;

            //Console.WriteLine("--------- Menü --------");
            //Console.WriteLine("");
            //Console.WriteLine("1-Tatlılar");
            //Console.WriteLine("2-İçecekler");
            //Console.WriteLine("3-Yemekler");
            //Console.WriteLine("-----------------------");
            //menu = int.Parse(Console.ReadLine());

            //if (menu == 1)
            //{
            //    Console.WriteLine("--------- Tatlılar --------");
            //    Console.WriteLine("1-Revani");
            //    Console.WriteLine("2-Trileçe");
            //    Console.WriteLine("3-Çikolata");
            //    Console.WriteLine("-----------------------");
            //}
            //else if (menu == 2)
            //{
            //    Console.WriteLine("--------- İçecekler --------");
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Meyvesuyu");
            //    Console.WriteLine("3-Ayran");
            //    Console.WriteLine("-----------------------");
            //}
            //else if (menu == 3)
            //{
            //    Console.WriteLine("--------- Yemekler --------");
            //    Console.WriteLine("1-Karışık Izgara");
            //    Console.WriteLine("2-Hamburger");
            //    Console.WriteLine("3-Beyti");
            //    Console.WriteLine("-----------------------");
            //}


            #endregion

            #region Switch Case Uygulaması Aylar;

            //Console.WriteLine("Lütfen ay girişi yapınız: ");
            //int ayNumarasi = int.Parse(Console.ReadLine());

            //switch (ayNumarasi)
            //{
            //    case 1: Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;
            //    default: Console.WriteLine("Lütfen 1-12 arasında bir ay sayısı giriniz"); break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            int number1, number2, islem, result=0;

            Console.WriteLine("Lütfen Birinci Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen İkinci Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Yapacağınız işlemi menüden seçiniz: ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1-Toplama");
            Console.WriteLine("2-Çıkarma");
            Console.WriteLine("3-Çarpma");
            Console.WriteLine("4-Bölme");
            Console.WriteLine("5-Kalan Bulma");
            islem = int.Parse(Console.ReadLine());

            switch (islem)
            {
                case 1: result = number1 + number2; break;
                case 2: result = number1 - number2; break;
                case 3: result = number1 * number2; break;
                case 4: result = number1 / number2; break;
                case 5: result = number1 % number2; break;
                default: Console.WriteLine("Yanlış Bir İşlem Seçtiniz");
                    break;
            }

            Console.WriteLine("İşlem Sonucu: "+ result);

            #endregion
            Console.Read();
        }
    }
}
