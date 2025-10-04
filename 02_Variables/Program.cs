using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8; // Konsol çıkışı UTF-8
            Console.InputEncoding = Encoding.UTF8;


            #region Double Değişkenler
            //double number;

            //number = 5.25;
            //Console.WriteLine(number);


            //double domatesPrice;
            //double salatalikPrice;
            //double nanePrice;
            //double havucPrice;
            //double karnibaharPrice;
            //double ispanakPrice;

            //domatesPrice = 15.25;
            //salatalikPrice = 25.45;
            //nanePrice = 26;
            //havucPrice = 17.85;
            //karnibaharPrice = 8.50;
            //ispanakPrice = 4.60;



            //Console.WriteLine("----- Fiyat Listesi -----");
            //Console.WriteLine("");
            //Console.WriteLine("---Domates Birim Fiyatı: "+ domatesPrice+ " ₺");
            //Console.WriteLine("---Salatalık Birim Fiyatı: "+salatalikPrice + " ₺");
            //Console.WriteLine("---Nane Birim Fiyatı: "+nanePrice + " ₺");
            //Console.WriteLine("---Havuç Birim Fiyatı: "+havucPrice + " ₺");
            //Console.WriteLine("---Karnıbahar Birim Fiyatı: "+karnibaharPrice + " ₺");
            //Console.WriteLine("---Ispanak Birim Fiyatı: "+ispanakPrice + " ₺");
            //Console.WriteLine("");
            //Console.WriteLine("--------------------------");

            //double domatesGram, salatalikGram, naneGram, havucGram, karnibaharGram, ispanakGram;

            //domatesGram =1.400; salatalikGram = 1.685; naneGram = 5.250; havucGram = 2.000; karnibaharGram = 4.520; ispanakGram = 6.325;

            //double domatesTotalPrice = domatesGram * domatesPrice;
            //double salatalikTotalPrice= salatalikGram * salatalikPrice;
            //double naneTotalPrice= naneGram * nanePrice;
            //double havucTotalPrice= havucGram * havucPrice;
            //double karnibaharTotalPrice= karnibaharGram * karnibaharPrice;
            //double ispanakTotalPrice= ispanakGram * ispanakPrice;
            //double ShoppingTotalPrice = domatesTotalPrice + salatalikTotalPrice + naneTotalPrice + havucTotalPrice + karnibaharTotalPrice + ispanakTotalPrice;

            //Console.WriteLine("------ SEPET -----");
            //Console.WriteLine("");
            //Console.WriteLine("Domates Alınan Gramaj ve Tutar: " + domatesGram + " gram. Toplam: " + domatesTotalPrice + " ₺");
            //Console.WriteLine("Salatalık Alınan Gramaj ve Tutar: : " + salatalikGram + " gram. Toplam: " + salatalikTotalPrice + " ₺");
            //Console.WriteLine("Nane Alınan Gramaj ve Tutar: : " + naneGram + " gram. Toplam: " + naneTotalPrice + " ₺");
            //Console.WriteLine("Havuç Alınan Gramaj ve Tutar: : " + havucGram + " gram. Toplam: " + havucTotalPrice + " ₺");
            //Console.WriteLine("Karnıbahar Alınan Gramaj ve Tutar: : " + karnibaharGram + " gram. Toplam: " + karnibaharTotalPrice + " ₺");
            //Console.WriteLine("Ispanak Alınan Gramaj ve Tutar: : " + ispanakGram + " gram. Toplam: " + ispanakTotalPrice + " ₺");
            //Console.WriteLine("Toplam Tutar: " + ShoppingTotalPrice + " ₺");
            #endregion

            #region Char Değişkenler

            //char symbol = 'A';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine("");

            //string passangerName, passangerSurname, passangerEmail, passangerPhone, passangerAge, passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("Yolcu Email: ");
            //passangerEmail = Console.ReadLine();

            //Console.Write("Yolcu Telefon Numarası: ");
            //passangerPhone = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passangerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No: ");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine("Yolcu: "+ passangerName+ " " + passangerSurname+ " " + passangerEmail+ " " + passangerPhone + " "+ passangerAge, " "+ passangerIdentityNumber);
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int ayakkabiPrice = 2500;
            //int arabaPrice = 300000;
            //int tisortPrice = 500;
            //int telefonPrice = 12500;

            //Console.WriteLine("Alınan Ayakkabı Sayısı: ");
            //int ayakkabiCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Alınan Araba Sayısı: ");
            //int arabaCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Alınan Tişört Sayısı: ");
            //int tisortCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Alınan Telefon Sayısı: ");
            //int telefonCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("");
            //Console.Write("Toplam Tutar: ");
            //Console.Write(ayakkabiPrice * ayakkabiCount + arabaPrice * arabaCount + tisortCount * tisortPrice + telefonCount * telefonPrice);

            ////totalPrice diye bir int değişken tanımlayıp count ve price çarpımlarını onda toplayıp kullanmak daha mantıklı olurdu.

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, exam4, result;

            //Console.Write("Lütfen 1.sınav notunu giriniz: ");
            //exam1= double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 4.sınav notunu giriniz: ");
            //exam4 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3 + exam4) / 4;

            //Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender= char.Parse(Console.ReadLine());

            Console.WriteLine(gender);


            #endregion

            Console.Read();
        }
    }
}
