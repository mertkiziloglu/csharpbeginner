using System;

namespace fibonaccitoplam
{
    class Program
    {
         public static void Main(string[] args)
         {
             int n1 = 0, n2 = 1, n3, i, number, ciftsayi = 0;    
                 Console.Write("Enter the number of elements: ");    
                 number = int.Parse(Console.ReadLine());  
                 for(i=2;i<number;++i)    
                 {    
                  n3=n1+n2;    
                  n1=n2;    
                  n2=n3;
                  if (n3%2==0)
                  {
                      ciftsayi += n3;
                  }

                 }
                 Console.WriteLine("ciftsayitoplami: "+ciftsayi);
         }  
    }
}