using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependancyInjectionExample
{
    class DapperDbReader : IDbReader
    {
        public void ExecuteStoredProcedure()
        {
           // TODO
        }

        public void Read()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            using (IDbConnection connecton = new SqlConnection(connectionString))
            {
                connecton.Open();
                var queryResult = connecton.Query<Worker>("SELECT * FROM Workers", new DynamicParameters()).ToList();
                Console.WriteLine("Dapper reder method:");
                Console.WriteLine("Workers Database");
                Console.WriteLine("Id\tName\tBossId\tSpecialityId\tIsBoss");
                foreach (var item in queryResult)
                {
                    Console.WriteLine(item.ToString());
                }
               
            }
        }
    }
}
