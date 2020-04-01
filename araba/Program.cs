using System;

namespace araba
{
    class Program
    {
      public static class Hesaplama
      {
          public static int Toplama(int a, int b)
          {
              return (a + b);
 
          }

      }
        
        
        public class Araba
                {
                    public string Marka;
                    public string Renk;
                    public string Model;
                    public int Agirlik;
        
                    public void start()
                    {
                        System.Console.WriteLine("{0} {1} calisti .",Marka,Model);
                    }
                   public void durdu() 
                   { 
                       System.Console.WriteLine("{0} {1} durdu.",Marka,Model);
                   } 
                    
                   public void hızlandi()
                   {
                       System.Console.WriteLine("{0} {1} hizlandi .",Marka,Model);
                   }
                   
                   public void yavasladi()
                   {
                       System.Console.WriteLine("{0} {1} yavasladi .",Marka,Model);
                   }
                }
        
                static void Main(string[] args)
                {
                  
                    Araba bmw =new Araba();
        
                    bmw.Marka = "bmw";
                    bmw.Renk = "beyaz";
                    bmw.Model = "x6";
                    bmw.Agirlik = 1250;
                    
                    
                    
                    bmw.start();
                    bmw.hızlandi();
                    bmw.yavasladi();
                    bmw.durdu();

                    int sonuc=Hesaplama.Toplama(10, 20);
                    Console.WriteLine(sonuc);

                }
    }
}
    
