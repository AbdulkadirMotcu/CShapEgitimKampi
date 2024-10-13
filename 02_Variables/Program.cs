using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Double Değişkenler

            //Console.WriteLine("***** Fiyat Listesi *****");

            //double applePrice,orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.45;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Brim Fiyatı" + applePrice + "TL");
            //Console.WriteLine("---- Portakal Brim Fiyatı" + orangePrice + "TL");
            //Console.WriteLine("---- Çilek Brim Fiyatı" + strawberryPrice + "TL");
            //Console.WriteLine("---- Patates Brim Fiyatı" + potatoPrice + "TL");
            //Console.WriteLine("---- Domates Brim Fiyatı" + tomatoPrice + "TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alına Ürün: Elma -  " +"Birim Fiyat :"+ applePrice + "- Gramaj : " + appleGram + "- Toplam Tutar: "+ appleTotalPrice);
            //Console.WriteLine("Alına Ürün: Portakal -  " + "Birim Fiyat :" + orangePrice + "- Gramaj : " + orangeGram + "- Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alına Ürün: Çilek -  " + "Birim Fiyat :" + strawberryPrice + "- Gramaj : " + strawberryGram + "- Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alına Ürün: Patates -  " + "Birim Fiyat :" + potatoPrice + "- Gramaj : " + potatoGram + "- Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alına Ürün: Domates -  " + "Birim Fiyat :" + tomatoPrice + "- Gramaj : " + tomatoGram + "- Toplam Tutar: " + tomatoTotalPrice);


            //double shoppingTotalPrice=appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;


            //Console.WriteLine();
            //Console.WriteLine();



            //Console.WriteLine("Alışverş Toplam Tutar :" + shoppingTotalPrice + "TL");



            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            #endregion


            #region Char Değişkenler

            //ABCDEFG
            //TOPLANTI SAAT 20:00'DE

            //char symbol;

            //symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion


            #region Klavyeden Veri Girişleri String Değişkenleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi****");

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Kimlik Numarası :");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.Write("Yolcu Adı :");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı :");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi :");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi : ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcy Yaşı :");
            //passengerAge = Console.ReadLine();



            //Console.WriteLine("-----------------");
            //Console.WriteLine("Yolcu Kimlik Numarası: " + passengerIdentityNumber);
            //Console.WriteLine("Yolcu Adı Ve Soyadı : " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Yolcu İlçesi Ve Şehri : " + passengerDistrict + "/"+ passengerCity);
            //Console.WriteLine("Yolcu Yaşı: " + passengerAge);


            #endregion


            #region Klavyeden Tam Sayı Girişmleri Ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütden Aldığınız Ayakkabı Sayını Giriniz : ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütden Aldığınız Bilgisayar Sayını Giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütden Aldığınız Sandalye Sayını Giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütden Aldığınız TV Sayını Giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesPrice * shoesCount + computerPrice * chairCount + chairPrice * chairCount + tvPrice * tvCount;

            //Console.WriteLine("Toplam Tutar : " + totalPrice + " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Soruncunu Giriniz : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Soruncunu Giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Soruncunu Giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Sınav Sonucu : " + result);


            #endregion


            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz : ");
            gender= char.Parse(Console.ReadLine());

            Console.WriteLine("Seceçeğiniz Cinsiyet : "+ gender);

            #endregion

            Console.Read();
        }
    }
}
