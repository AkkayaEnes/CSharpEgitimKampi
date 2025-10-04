using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Selam");
            //Console.Write("Hello World");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine("");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine("");
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            //string
            //değişken_türü değişken adı;

            //string name;
            //name = "Enes";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, customerdistrict, customercity;

            //customerName = "Enes";
            //customerSurname = "Akkaya";
            //customerPhone = "+90 536 945 9467";
            //customerEmail = "Akkayaakkaya789@gmail.com";
            //customerdistrict = "Hasköy";
            //customercity = "Ankara";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine("");
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("E-Mail Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + customerdistrict + " " + customercity);
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("");
            //customerName = "Nur";
            //customerSurname = "Aygör";
            //customerPhone = "+90 542 658 7496";
            //customerEmail = "test@gmail.com";
            //customerdistrict = "Mamak";
            //customercity = "Ankara";

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("E-Mail Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + customerdistrict + " " + customercity);
            //Console.WriteLine("-------------------------------------------------");


            #endregion

            #region Int Değişkenler

            //int
            int number = 12;
            Console.WriteLine(number);

            int hamburgerPrice = 300;
            int coke = 35;
            int waterPrice = 5;
            int friesPrice = 55;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatları *****");
            Console.WriteLine("");
            Console.WriteLine("----Kola "+ coke + "TL");
            Console.WriteLine("----Hamburger "+ hamburgerPrice + "TL");
            Console.WriteLine("----Su " + waterPrice + "TL");
            Console.WriteLine("----Kızartma "+ friesPrice + "TL");
            Console.WriteLine("----Pizza "+ pizzaPrice + "TL");
            Console.WriteLine("----Limonata "+ lemonadePrice + "TL");
            Console.WriteLine("");
            Console.WriteLine("***** Restoran Menü Fiyatları *****");

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;

            hamburgerCount = 3;
            cokeCount = 5;
            waterCount = 2;
            friesCount = 8;

            int totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            int totalCokePrice = coke * cokeCount;
            int totalWaterPrice = waterPrice * waterCount;
            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice;

            Console.WriteLine("--------- Hesap Tutarı ----------");
            Console.WriteLine("Hamburger: " + totalHamburgerPrice);
            Console.WriteLine("Kola: " + totalCokePrice);


            #endregion
            Console.Read();
        }
    }
}



//Yazdırma Komutları
