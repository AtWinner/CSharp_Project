using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TK70561
{
    class Program
    {
        static void Main(string[] args)
        {
            //Configure and open the database connection here
            SqlConnection theConnection = new SqlConnection();
            theConnection.ConnectionString = "Data Source=86BBAJI3MJ0T1JY;Initial Catalog=VideoGameStoreDB;Integrated Security=SSPI;";
            theConnection.Open();
            if (theConnection.State == System.Data.ConnectionState.Open)
                Console.WriteLine("Open");
        }
    }
}
