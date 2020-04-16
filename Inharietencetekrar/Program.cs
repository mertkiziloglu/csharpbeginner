using System;
using System.Globalization;
using System.Security.Cryptography;

namespace Inharietencetekrar
{
    class Program
    {

        class Person                                    //inharietence sınıfım person sınıfı
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        class Customer:Person                        //person sınıfın yavrusu ise customer sınıfı
        {
            public string Deparment { get; set; }
        }

        class Student:Person
        {
            public String School { get; set; }  // anasınıftan ayrı özellik ekleyebilirim 
        }
        
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]            
            {
                new Person{Name = "prof"},          //köşeli parantez koydum dikkat et!!
                new Customer{Name = "dr"},
                new Student{Name = "Mert"}
            };
            foreach (var VARIABLE in persons)
            {
                Console.WriteLine();
            }

        }
    }
}