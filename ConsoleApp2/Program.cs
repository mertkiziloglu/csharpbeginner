using System;
using System.Collections.Concurrent;

namespace ilkstringdeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad;
            int sayi;

            Console.WriteLine("1 ile 7 arasında bir sayi giriniz");
            sayi = Convert.ToInt16(Console.ReadLine());

            switch (sayi)
            {
            case 1: Console.WriteLine("gün pazartesi");
                break;
            case 2: Console.WriteLine("gün sali");
                break;
            case 3: Console.WriteLine("gün carsamba");
                break;
            case 4: Console.WriteLine("gün persembe");
                break;
            case 5: Console.WriteLine("gün cuma");
                break;
            case 6: Console.WriteLine("gün cumartesi");
                break;
            case 7: Console.WriteLine("gün  pazar");
                break;
            }
        }
    }
}