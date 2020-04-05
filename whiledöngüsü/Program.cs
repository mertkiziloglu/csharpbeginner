using System;

namespace whiledöngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("lütfen bir sayi giriniz..");
           i = Convert.ToInt32(Console.ReadLine());
            while (i%2==0)
            {
                Console.WriteLine("girdiginiz sayi cifttir.");
                Console.Read();
            }

            Console.WriteLine("girdigin sayi tektir");
         
        }
    }
}