using elevator_control_system.Database;
using MySqlConnector;
using System;

namespace elevator_control_system.Controllers
{
    internal class ClearElevatorLog
    {

        private DatabaseConnection db = new DatabaseConnection();  // Database connection instance


        // Method that handles the clear logs functionality (deletes all logs)
        public bool ClearLogs()
        {
            bool isLogsCleared = false;  // variable to track whether logs were cleared successfully
            MySqlConnection conn = db.Connect();  // Establish a connection to the database

            if (conn != null)
            {
                try
                {
                    // SQL query to delete all logs from the elevator_logs table
                    string query = "TRUNCATE TABLE elevator_logs";

                    // Use MySqlCommand to execute the TRUNCATE query
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Execute the TRUNCATE query
                        int result = cmd.ExecuteNonQuery();

                        // Check if the operation was successful
                        if (result >= 0)
                        {
                            isLogsCleared = true;  // If successful, set the flag to true
                        }
                        else
                        {
                            isLogsCleared = false;  // If unsuccessful, set the flag to false
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error deleting elevator log: " + ex.Message);
                    isLogsCleared = false;
                }
                finally
                {
                    // Always close the database connection after use
                    db.Close(conn);
                }
            }

            return isLogsCleared;  // Return whether logs were successfully cleared
        }
    }
}
