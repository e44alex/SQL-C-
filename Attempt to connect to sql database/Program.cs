using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient ;

namespace Attempt_to_connect_to_sql_database
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=TEST;Integrated Security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Users", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0} {1}", reader.GetString(0), reader.GetString(1));
            }

            Console.ReadKey();
        }
    }
}
