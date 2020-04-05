using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hosgeldiniizzzz !");
            Console.WriteLine("****************");
            Console.WriteLine("lütfen 10 tane isim giriniz.");
            Console.WriteLine("*****************");
            
            
            string[] isim=new string[10];
            
            for (int i = 0; i <isim.Length; i++)
            {
                Console.Write("isim"+i+"=");
                isim[i] = Console.ReadLine();
                
            }

            Console.WriteLine("******************");
            Console.WriteLine("aranacak ismi girin lütfen:");
            Console.WriteLine("*******************");
            
            string aranacak = Console.ReadLine();
            
                               int sayac = 0;
            
            for (int i = 0; i < isim.Length; i++)
            {
                if (aranacak==isim[i])
                {
                    sayac++;
                }
            }

            Console.WriteLine("Aradıginiz kelime "+sayac+" kadardir.");
            
        }
    }
}