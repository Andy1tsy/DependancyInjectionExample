using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DependancyInjectionExample
{
    public class AdoNetDbReader : IDbReader
    {
        public void Read()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlConnection sqlConn = new SqlConnection(connectionString);
            sqlConn.Open();
            SqlCommand sqlCmd = sqlConn.CreateCommand();
            sqlCmd.CommandText = "SELECT * FROM Workers";
            SqlDataReader sql_datareader = sqlCmd.ExecuteReader();
            Console.WriteLine("AdoNet method:");
            Console.WriteLine("Workers Database");
            Console.WriteLine("Id\tName\tBossId\tSpecialityId\tIsBoss");

            while (sql_datareader.Read())
            {
                string myreader0 = sql_datareader.GetValue(0).ToString();
                string myreader1 = sql_datareader.GetValue(1).ToString();
                string myreader2 = sql_datareader.GetValue(2).ToString();
                string myreader3 = sql_datareader.GetValue(3).ToString();
                string myreader4 = sql_datareader.GetValue(4).ToString();
                Console.WriteLine($"{myreader0}\t{myreader1}\t{myreader2}\t{myreader3}\t\t{myreader4}");
            }

            sqlConn.Close();
        }

        public void ExecuteStoredProcedure()
        {

            var connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ToString();
            SqlConnection sqlConn = new SqlConnection(connectionString);
           
            using (var command = new SqlCommand("sp_SelectTop", sqlConn)
                    { CommandType = CommandType.StoredProcedure  })
            {
                sqlConn.Open();
               var res =  command.ExecuteNonQuery();
                Console.WriteLine(res);
            }


        }

    }
}
