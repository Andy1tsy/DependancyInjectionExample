using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader1 =  DIConfig.Configure("AdoNet");
            reader1.Read();
            reader1.ExecuteStoredProcedure();

            var reader2 = DIConfig.Configure("Dapper");
            reader2.Read();

            var reader3 = DIConfig.Configure("EF");
            reader3.Read();

            Console.ReadLine();
        }



    }
}
