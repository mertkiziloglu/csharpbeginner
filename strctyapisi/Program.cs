using System;

namespace strctyapisi
{
    public struct hesaplama
    {
        public int kisa;
        public int uzun;

        public int alan()
        {
            return kisa* uzun;
        }


    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            hesaplama dikdörtgen=new hesaplama();

            dikdörtgen.kisa = 50;
            dikdörtgen.uzun = 70;

            dikdörtgen.alan();
            Console.WriteLine(dikdörtgen.alan());
            
        }
    }
}