﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Açıklama satırı Yazdırma komutları


//Console.WriteLine("Selam");
//Console.Write("Merhaba Dünya");
#region Yazdırma Komutlari

//Console.WriteLine("*****Yemek Kategoreleri******");
//Console.WriteLine("");
//Console.WriteLine("1-Çorbalar");
//Console.WriteLine("2-Ana Yemekler");
//Console.WriteLine("3-Soğuk Başlangıçlar");
//Console.WriteLine("4-Salatalar");
//Console.WriteLine("5-Tatlılar");
//Console.WriteLine("6-İçecekler");
//Console.WriteLine("");
//Console.WriteLine("*****Yemek Kategoreleri******");

#endregion




#region StringDeğişkenler

//string name;

//Name = "Murat";

//Console.Write(Name);

//string customerName;
//string customerSurname;
//string customerPhone;
//string customerEmail, district, city;

//customerName = "Kadir";
//customerSurname = "Motcu";
//customerPhone = "+90 566 666 66 66";
//customerEmail = "deneme@gmail.com";
//district = "Fatih";
//city = "İstanbul";

//Console.WriteLine("**** Rezervasyon Kartı *****");
//Console.WriteLine();
//Console.WriteLine("------------------------------------------------");
//Console.WriteLine("Müsteri: " + customerName + " " + customerSurname );
//Console.WriteLine("İletişim: " +  customerPhone);
//Console.WriteLine("Email Adresi: " + customerEmail);
//Console.WriteLine("Adres: " + district + "/" + city );
//Console.WriteLine("------------------------------------------------");


//Console.WriteLine();


//customerName = "Damla";
//customerSurname = "Kaya";
//customerPhone = "+90 544 665 34 23";
//customerEmail = "test@gmail.com";
//district = "Şişli";
//city = "İstanbul";


//Console.WriteLine("------------------------------------------------");
//Console.WriteLine("Müsteri: " + customerName + " " + customerSurname);
//Console.WriteLine("İletişim: " + customerPhone);
//Console.WriteLine("Email Adresi: " + customerEmail);
//Console.WriteLine("Adres: " + district + "/" + city);
//Console.WriteLine("------------------------------------------------");




#endregion




#region IntDeğişklenler
//int number = 34;
//Console.WriteLine(number);

int hamburgerPrice = 300;
int cokePrice = 35;
int waterPrice = 10;
int friesPrice = 50;
int pizzaPrice = 250;
int lemonadePrice = 30;

Console.WriteLine("**** Restoran Menü Fiyatı");
Console.WriteLine();
Console.WriteLine("------Hmburger : " + hamburgerPrice + " TL");
Console.WriteLine("------Pizza : " + pizzaPrice + " TL");
Console.WriteLine("------Kola : " + cokePrice + " TL");
Console.WriteLine("------Limonata : " + lemonadePrice + " TL");
Console.WriteLine("------Kızartma : " +friesPrice + " TL");
Console.WriteLine("------Su : " + waterPrice + " TL");
Console.WriteLine();
Console.WriteLine("**** Restoran Menü Fiyatı");

Console.WriteLine();

int hamburgerCount;
int cokeCount;
int waterCount;
int friesCount;
int pizzaCount;
int lemonadeCount;

int totalHamburgerPrice;
int totalCokePrice ;
int totalWaterPrice;    
int totalFriesPrice;
int totalPizzaPrice;
int totalLemonadePrice;

hamburgerCount = 3;
cokeCount = 3;
waterCount = 3;
friesCount = 1;
pizzaCount = 0;
lemonadeCount = 0;

totalHamburgerPrice = hamburgerCount * hamburgerPrice ;
totalCokePrice = cokeCount * cokePrice;
totalWaterPrice = waterCount * waterPrice ;
totalFriesPrice = friesCount * friesPrice ; 
totalLemonadePrice = lemonadeCount * lemonadePrice ;
totalPizzaPrice = pizzaCount * pizzaPrice ;


Console.WriteLine("--------------------------");
Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL");
Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

int totalPrice= totalCokePrice + totalWaterPrice+ totalFriesPrice+ totalHamburgerPrice + totalPizzaPrice + totalLemonadePrice;
Console.WriteLine();

Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice);


#endregion
