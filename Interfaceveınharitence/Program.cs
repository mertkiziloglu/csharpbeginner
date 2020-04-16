using System;

namespace Inharietance
{
    class Program
    {
        static void Main(string[] args)
        {
       
           Sql sqlserver=new Sql();
           sqlserver.Add();
           MySql mySqlserver=new MySql();
           mySqlserver.Delete();
         
        }

        class Database
        {
            public virtual void Add()               //virtuali eklmemeizin sebebi bu özelliği ezebilirsin demek
            {
                Console.WriteLine("Added by default!");
            }

            public virtual void Delete()
            {
                Console.WriteLine("Delete by default!");
            }
        }

        class Sql:Database
        {
            public override void Add()
            {
                Console.WriteLine("Add by Sql server!");
                base.Add();   // base demek sql in babasını çağır anlamında override yapıyoruz.
            }
        }

        class MySql:Database
        {
            
        }
    }
    
}