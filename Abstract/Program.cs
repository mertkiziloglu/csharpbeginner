using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Database database=new Oracle();
            database.Add();
            database.Delete();
            Database database2=new Sql();
            database2.Add();
            database2.Delete();
        }
        
         abstract class Database 
        {
            public void Add()
            {
                Console.WriteLine("Added by Default.");
            }

            public abstract void Delete();
        }

         class Oracle:Database
         {
             public override void Delete()   // abstract class olduğu için sadeece bunu ekleyebiliroyrum
             {
                 Console.WriteLine("Delete Oracle."); 
             }
         }

         class Sql:Database
         {
             public override void Delete()
             {
                 Console.WriteLine("Delete SqlServer");
             }
         }
    }
    
}