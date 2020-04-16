using System;

namespace RecapDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            customerManager.logger=new DatabaseLogger();
            customerManager.Add();
            
        }

        class CustomerManager:ILogger
        {
            public DatabaseLogger logger;
            public ILogger Logger { get; set; }

            public void Add()
            {
                DatabaseLogger logger=new DatabaseLogger();
                logger.log();
                Console.WriteLine("Added Customer!");
            }

            public void log()
            {
                Console.WriteLine("logged to Customer ");  
            }
        }

        class DatabaseLogger:ILogger
        {
            public void log()
            {
                Console.WriteLine("Logged to Database"); 
            }
        }

        interface ILogger
        {
            void log();
        }
    }
}