using System;
using MySqlConnector;

namespace elevator_control_system.Database
{
    internal class DatabaseConnection
    {
        // creating a mysql connection object
        private MySqlConnection connection = null;


        // Connection string to MySQL database
        private string url = "datasource= localhost; database=elevator; port=3306; user=root; password= ";


        public MySqlConnection Connect()
        {
            try
            {
                // Initialize the connection
                connection = new MySqlConnection(url);
                connection.Open();  // Open the connection
                Console.WriteLine("Connected to MySQL database.");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error connecting to database: " + ex.Message);
            }

            return connection;
        }

        public bool Close(MySqlConnection connection)
        {
            bool result = false;
            try
            {
                connection.Close();  // Close the connection
                Console.WriteLine("Connection closed.");
                result = true;
            }
            catch (Exception ex)
            {
                // Handle errors during closing the connection
                Console.WriteLine("Error closing connection: " + ex.Message);
            }
            return result;
        }

    }
}
