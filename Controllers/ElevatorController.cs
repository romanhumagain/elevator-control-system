using elevator_control_system.Database;
using elevator_control_system.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;

namespace elevator_control_system.Controllers
{
    internal class ElevatorController
    {
        private DatabaseConnection db = new DatabaseConnection();  // Database connection instance

        // Method to insert a new log into the database
        public void InsertElevatorLog(ElevatorLog log)
        {
            MySqlConnection conn = db.Connect();  // Establish a connection to the database

            if (conn != null)
            {
                try
                {
                    // SQL query to insert a new log into the elevator_logs table
                    string query = "INSERT INTO elevator_logs (date, requested_at, action) VALUES (@date, @requestedAt, @action)";

                    // Create a MySQL command object with the query and connection
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Bind parameters to prevent SQL injection (binding the values to the query)
                    cmd.Parameters.AddWithValue("@date", log.Date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@requestedAt", log.RequestedAt);
                    cmd.Parameters.AddWithValue("@action", log.Action);

                    // Execute the query to insert the log
                    int result = cmd.ExecuteNonQuery();

                    // Check if the insertion was successful
                    if (result > 0)
                    {
                        Console.WriteLine("Elevator log inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to insert elevator log.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error inserting elevator log: " + ex.Message);
                }
                finally
                {
                    // close the database connection after use
                    db.Close(conn);
                }
            }
            else
            {
                // If the connection fails, print an error
                Console.WriteLine("Failed to connect to the database.");
            }
        }

        // Method to fetch the latest elevator logs from the database
        public List<ElevatorLog> GetLatestElevatorLogs()
        {
            List<ElevatorLog> logs = new List<ElevatorLog>();  // Create an empty list to store logs
            MySqlConnection conn = db.Connect();  // Establish a connection to the database

            if (conn != null)
            {
                try
                {
                    // SQL query to select all logs ordered by date and requested_at descending
                    string query = "SELECT logs_id, date, requested_at, action FROM elevator_logs ORDER BY date DESC, requested_at DESC";

                    // Create a MySQL command object with the query and connection
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Execute the query and get a data reader to fetch the results
                    MySqlDataReader reader = cmd.ExecuteReader();

                    // Read each log from the data reader and add it to the logs list
                    while (reader.Read())
                    {
                        ElevatorLog log = new ElevatorLog
                        {
                            LogsId = reader.GetInt32("logs_id"),
                            Date = reader.GetDateTime("date"),
                            RequestedAt = reader.GetTimeSpan("requested_at"),
                            Action = reader.GetString("action")
                        };
                        logs.Add(log);  // Add the log to the list
                    }

                    reader.Close();  // Close the reader after use
                }
                catch (Exception ex)
                {
                    // If there's an error, print it
                    Console.WriteLine("Error fetching elevator logs: " + ex.Message);
                }
                finally
                {
                    // close the database connection after use
                    db.Close(conn);
                }
            }
            else
            {
                // If the connection fails, print an error
                Console.WriteLine("Failed to connect to the database.");
            }

            return logs;  // Return the list of fetched logs
        }

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
                    String query = "TRUNCATE TABLE elevator_logs";

                    // Create a MySQL command object with the query and connection
                    MySqlCommand command = new MySqlCommand(query, conn);

                    // Execute the query to delete all logs
                    command.ExecuteNonQuery();
                    isLogsCleared = true;  // If successful, set the flag to true
                }
                catch (Exception ex)
                {
                    // If there's an error, print it and set the flag to false
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
