using System;

namespace DegerVeReferanTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1=?       cevap:30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=?   cevap:999


            //    stock                  heap                            stock                    heap
            //    sayi1=!10 = 30                                       sayilar1---------->/101(102)/[10,20,30]        101= adres-pointer
            //    sayi2=!30 = 65                                       sayilar2---------->/102/[100(999),200,300]             
        }
    }
}


// int, decimal, float, double, bool = değer tip
// array, class, interface = referans tip
