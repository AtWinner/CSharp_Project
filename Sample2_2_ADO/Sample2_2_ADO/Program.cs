using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Sample2_2_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            string theConnectionString = "Data Source=86BBAJI3MJ0T1JY;Initial Catalog=VideoGameStoreDB;Integrated Security=SSPI;";

            SqlConnection theConnection = new SqlConnection(theConnectionString);
            theConnection.Open();//打开数据库连接

            if (theConnection.State == ConnectionState.Open)
                Console.WriteLine("Database Connection is open!\n");
            SqlCommand theCommend = new SqlCommand();

            theCommend.Connection = theConnection;
            theCommend.CommandText = "SELECT * FROM product";
            try
            {
                theCommend.CommandType = CommandType.Text;
                SqlDataAdapter theDataAdapter = new SqlDataAdapter(theCommend);
                SqlCommandBuilder theCommendBuilder = new SqlCommandBuilder(theDataAdapter);
                Console.WriteLine(theCommendBuilder.GetInsertCommand().CommandText + "\n\n");
                Console.WriteLine(theCommendBuilder.GetUpdateCommand().CommandText + "\n\n");
                Console.WriteLine(theCommendBuilder.GetDeleteCommand().CommandText + "\n\n");
            }
            catch (SqlException sqlexception)
            {
                Console.WriteLine(sqlexception);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            

        }
    }
}
