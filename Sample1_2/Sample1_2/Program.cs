using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Sample1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //configure and open the database connection here
            string theConnectionString = "Data Source=86BBAJI3MJ0T1JY;Initial Catalog=VideoGameStoreDB;Integrated Security=SSPI;Workstation ID=Odin;Connect Timeout=5;";//+Network Library=dbmssocn;


            SqlConnection theConnection = new SqlConnection(theConnectionString);
            theConnection.Open();
            if (theConnection.State == System.Data.ConnectionState.Open)
                Console.WriteLine("Database Connection is open");
        }
    }
}
