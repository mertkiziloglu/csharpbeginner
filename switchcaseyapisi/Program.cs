using System;
using System.ComponentModel;

namespace switchcaseyapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi, i, taksit;

            Console.WriteLine("*********************");
            Console.WriteLine("Merhabalar lütfen ödeme sesecenegini secin:");
            Console.WriteLine("*********************");
            Console.WriteLine("1-Nakit ödeme  2-Taksitli ödeme");
            Console.WriteLine("*********************");
            sayi = Convert.ToUInt16(Console
                .ReadLine()); //burası önemli!! burda çeviri yapmazsak makine dili string olarak alır 

            switch (sayi)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Nakit ödeme yaptiniz.. iyi günler dileriz");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Taksitli ödeme yaptınız.. iyi günler dileriz");
                    Console.WriteLine();
                    break;

            }

        }
    }
}
