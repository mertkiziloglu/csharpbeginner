using System;

namespace Inharietance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons=new Person[3]
            {
                new Customer {FirstName = "mert"}, 
                new Student {FirstName = "Kiziloglu"}, 
                new Person {FirstName = "kübra"}
            };
            
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }
}