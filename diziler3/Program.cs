using System;

namespace diziler3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[5];

            int i;
            for (i = 0; i < 5; i++)
            {
                Console.Write((i + 1).ToString() + ".Sayiyi girin:");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            } 
            int enbüyük;
            enbüyük = dizi[0];
        for (i = 0; i<5; i++)
        {

            if (enbüyük < dizi[i])
            {
                enbüyük = dizi[i];
            }

            
        }   
Console.WriteLine(enbüyük); 
        }

       
    }

}


  