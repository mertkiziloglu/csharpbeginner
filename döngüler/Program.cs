using System;

namespace döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            Console.WriteLine();
            Console.WriteLine("***********************");
            for (int i = 0; i <100; i++)
            {
                
                toplam += i;
            }

            Console.WriteLine($"1den yüze kadar olan sayilarin toplami:{toplam}");
            Console.WriteLine("***********************");
               
           
        }
    }
}