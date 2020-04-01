using System;

namespace diziler2
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] isimler = new string[24];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("isim:");
                isimler[i] = Console.ReadLine();
            }
           
        }
    }
}
