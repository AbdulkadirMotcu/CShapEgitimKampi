using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _03_MakingDecision
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region If Else

            //Console.Write("Lütfen Şifreyi Giriniz : ");
            //string password;

            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else {
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;

            //Console.WriteLine("Başkenti Giriniz :");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi Giriniz : ");
            //country = Console.ReadLine();

            //if (capital == "ankara" && country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");

            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}

            int number;

            Console.Write("Sayı Giriniz : ");
            number = int.Parse(Console.ReadLine());

            if (number == 5)
            {
                Console.WriteLine("Sayı Doğru");

            }
            else
            {
                Console.WriteLine("Sayı Hatalı");
            }




            Console.Read();


                #endregion


            }
        }
    }
