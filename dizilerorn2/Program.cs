using System;

namespace dizilerorn2
{
    class Program
    {
        static void Main(string[] args)
        {
          //kullanıcıdan 20 sayi alan ve tekleri ciftleri toplayan program
          
          int [] sayilar=new int[5];

          for (int i = 0; i <5; i++)
          {
              Console.WriteLine("lütfen sayi giriniz: ");
              sayilar[i] = Convert.ToInt16(Console.ReadLine());
          }
          Console.Clear();
           
          int teksayi = 0, ciftsayi = 0;
          
          foreach (int sayi in sayilar)
          {
              if (sayi%2==0)
              {
                  ciftsayi += sayi;
              }
              else
              {
                  teksayi += sayi;
              }
          }
          Console.WriteLine("tek sayi: {0}  \ncift sayi:{1}",teksayi,ciftsayi);
        }
    }
}