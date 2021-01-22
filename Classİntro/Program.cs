using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Akif";
            int yas = 21;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdı = "C#";
            kurs1.Eğitmeni = "Engin Demiroğ";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdı = "Java";
            kurs2.Eğitmeni = "Kerem Barış";
            kurs2.IzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdı = "Python";
            kurs3.Eğitmeni = "Berkay Bilgin";
            kurs3.IzlenmeOranı = 80;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdı = "C++";
            kurs4.Eğitmeni = "Murat Kurtboğan";
            kurs4.IzlenmeOranı = 100;

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4 };


            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdı + " : " + kurs.Eğitmeni);
            }

            //Console.WriteLine(kurs1.KursAdı + " : " + kurs1.Eğitmeni);
            //Console.WriteLine("Hello World!");
        }
    }
    class Kurs
    {
        public string KursAdı { get; set; }
        public string Eğitmeni { get; set; }
        public int IzlenmeOranı { get; set; }


    } 


}
