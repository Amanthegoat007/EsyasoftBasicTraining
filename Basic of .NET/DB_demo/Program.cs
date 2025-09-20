using System;
using System.Data.SqlClient;
namespace DB_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Getting Connection ...");

            var datasource = @"LAPTOP-QD1INAQE"; // your server
            var database = "v2_DB_Demo"; // your database name
            //var username = "DESKTOP-LCNNVH9\\kk"; // username of server to connect
            //var password = ""; // password

            // Create your connection string
            string connString = @"Data Source=" + datasource +
                ";Initial Catalog=" + database + "; Trusted_Connection=True;";


            Console.WriteLine(connString);

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                Console.WriteLine("Opening Connection ...");
                // Open the connection
                conn.Open();
                Console.WriteLine("Connection successful!");
                //InsertStaff(conn);
                displayStaff(conn);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }


        }
        static void InsertStaff(SqlConnection conn)
        {
            Console.Write("Enter the Staff Name...");

            string myname = "Sachin2";
            int id = 1;
            string phoneNo = "32423432";
            string querry = "insert into Student values(@id, @myname, @phoneNo)";
            SqlCommand cm = new SqlCommand(querry, conn);
            cm.Parameters.AddWithValue("@id", id);
            cm.Parameters.AddWithValue("@myname", myname);
            cm.Parameters.AddWithValue("@phoneNo", phoneNo);
            int rows = cm.ExecuteNonQuery();
            if (rows > 0)
            {
                Console.WriteLine("Inseted recordsuccessfully");
            }


        }
        static void displayStaff(SqlConnection conn)
        {
            string query = "select * from Student";
            SqlCommand cm = new SqlCommand(query, conn);
            SqlDataReader reader = cm.ExecuteReader();
            //Console.WriteLine("Staff :");
            while (reader.Read())
            {
                {
                    Console.WriteLine($"Name :{reader["name"]}");
                    Console.WriteLine($"Name :{reader["id"]}");
                    Console.WriteLine($"Name :{reader["phoneNo"]}");

                }
            }
        }
    }
}
