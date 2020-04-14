using System;
using System.Data;
using System.Data.SqlClient;

namespace MyConsoleApp
{
    class Program
    {
        static void Main()
        {
            const string conString = @"Data source=NILUFARSHEROVA; Initial catalog=AlifAcademy; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == ConnectionState.Open)System.Console.WriteLine("Connected successfully");
            else System.Console.WriteLine("Troubles with connection"); 
            string commandText  = "Select *from TablePerson";
            SqlCommand command = new SqlCommand(commandText, con);
            SqlDataReader reader  = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"ID: {reader.GetValue(0)}, Firstname:{reader.GetValue(1)}, LastName:{reader.GetValue(2)}");
            }
        }
    }
}