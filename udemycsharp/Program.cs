using System;

namespace udemycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("lütfen yasınızı girin:   ");
            int yas = Convert.ToInt16(Console.ReadLine());

            if (yas>=18)
            {
                Console.Write("eğitim durumunuzu girin: ");
                string egitim = Convert.ToString(Console.ReadLine());
                if (egitim=="lise" || egitim=="üniversite")
                {
                    Console.WriteLine("ehliyet alabilirsiniz.. ");
                }
                else
                {
                    Console.WriteLine("egitim durumunuz uygun degil.");
                }
            }
            else
            {
                Console.WriteLine("18yasında olmadiginiz icin ehliyet alamazsiniz..");
            }
        }
    }
}