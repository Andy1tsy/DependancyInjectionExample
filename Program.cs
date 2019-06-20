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
            ExecuteMethod(reader1);
            reader1.ExecuteStoredProcedure();

            var reader2 = DIConfig.Configure("Dapper");
            ExecuteMethod(reader2);

            var reader3 = DIConfig.Configure("EF");
            ExecuteMethod(reader3);

            Console.ReadLine();
        }

        private static void ExecuteMethod(IDbReader dbReader)
        {
            //m.b. some logic
            dbReader.Read();
        }

    }
}
