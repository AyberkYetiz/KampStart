using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("**********Fiyat Listesi*************");
            //Console.WriteLine();

            //double applePrice, orangePrice, cilekPrice, potato, tomato;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //cilekPrice = 45;
            //potato = 9.74;
            //tomato = 6.88;
            //Console.WriteLine("----Elma Fiyatı-----"+applePrice);
            //Console.WriteLine("----Portakal Fiyatı-----" + orangePrice);
            //Console.WriteLine("----Çilek Fiyatı-----" + cilekPrice);
            //Console.WriteLine("----Patates Fiyatı-----" + potato);
            //Console.WriteLine("----Domates Fiyatı-----" + tomato);

            //double appleGram, orangeGram, cilekGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //cilekGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;
            //double appleTotalPrice=applePrice*appleGram;
            //double orangeTotalPrice=orangePrice*orangeGram;
            //double cilekTotalPrice=cilekPrice*orangeGram;
            //double potatoTotalPrice=potato*potatoGram;
            //double tomatoTotalPrice=tomato  *tomatoGram;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();


            //Console.WriteLine("---Elma Total Fiyatı"+appleTotalPrice);
            //Console.WriteLine("---Portakal Total Fiyatı"+orangeTotalPrice);
            //Console.WriteLine("---Çilek Total Fiyatı"+cilekTotalPrice);
            //Console.WriteLine("---Patates Total Fiyatı"+potatoTotalPrice);
            //Console.WriteLine("---Domates Total Fiyatı"+tomatoTotalPrice);

            //double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+cilekTotalPrice+potatoTotalPrice+tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("----Total Tutar:"+shoppingTotalPrice);




            #endregion

            #region Char
            //char symbol;
            //symbol = 'A';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişi
            //Console.WriteLine("----C#------------");
            //string passengerName,passengerSurname,passengerDistrict,passengerCity,passengerAge,passengerIdentityNumber;
            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi:");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir:");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş:");
            //passengerAge = Console.ReadLine();


            //Console.Write("Yolcu TC:");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("-------------");
            //Console.WriteLine("Yolcu Adı:"+passengerName+" "+"Yolcu Soyadı:"+passengerSurname+" "+passengerDistrict+" "+passengerCity+" "+" "+passengerAge+" "+passengerIdentityNumber);
            #endregion

            #region Klavyeden tamsayı girişi ve dönüşümleri

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.WriteLine("Lütfen alınan Ayakkabı sayısını giriniz:");
            //shoesCount = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Lütfen alınan Bilgisayar sayısını giriniz:");
            //computerCount = int.Parse(Console.ReadLine());//Her iki kullanım da okey.

            //Console.WriteLine("Lütfen alınan Sandalye sayısını giriniz:");
            //chairCount = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("Lütfen alınan Televizyon sayısını giriniz:");
            //tvCount = Convert.ToInt16(Console.ReadLine());

            //int totalPrice=shoesCount*shoesPrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;
            //Console.WriteLine("Ödemeniz gereken tutar:"+totalPrice);

            #endregion
            #region Klavyeden Ondalıklı Sayı Girişi

            double exam1, exam2, exam3, resault;

            Console.Write("Sınav1:");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Sınav2:");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Sınav3:");
            exam3 = double.Parse(Console.ReadLine());

            resault = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Sınav Ortalamanız:" + resault);


            #endregion
            #region Klavyeden karakter girişi
            char gender;
            Console.Write("Cinsiyetinizi giriniz");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Seçim:" + gender);

            #endregion




            Console.Read();

        }
    }
}

