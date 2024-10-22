using elevator_control_system.Database;  // Import your DatabaseConnection
using elevator_control_system.Models;    // Import your ElevatorLog model
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
            MySqlConnection conn = db.Connect();  // Establish a connection

            if (conn != null)
            {
                try
                {
                    // SQL query to insert a new log into the elevator_logs table
                    string query = "INSERT INTO elevator_logs (date, requested_at, action) VALUES (@date, @requestedAt, @action)";

                    // Create a MySQL command object
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Bind parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@date", log.Date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@requestedAt", log.RequestedAt);
                    cmd.Parameters.AddWithValue("@action", log.Action);

                    // Execute the query
                    int result = cmd.ExecuteNonQuery();

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
                    // Close the database connection
                    db.Close(conn);
                }
            }
            else
            {
                Console.WriteLine("Failed to connect to the database.");
            }
        }


        // Method to fetch the data from the table 
        public List<ElevatorLog> GetLatestElevatorLogs()
        {
            List<ElevatorLog> logs = new List<ElevatorLog>();
            MySqlConnection conn = db.Connect();

            if (conn != null)
            {
                try
                {
                    // SQL query to select all logs, ordered by date and requested_at descending
                    string query = "SELECT logs_id, date, requested_at, action FROM elevator_logs ORDER BY date DESC, requested_at DESC";

                    // Create a MySQL command object
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Execute the query
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ElevatorLog log = new ElevatorLog
                        {
                            LogsId = reader.GetInt32("logs_id"),
                            Date = reader.GetDateTime("date"),
                            RequestedAt = reader.GetTimeSpan("requested_at"),
                            Action = reader.GetString("action")
                        };
                        logs.Add(log);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching elevator logs: " + ex.Message);
                }
                finally
                {
                    // to close the database 
                    db.Close(conn);
                }
            }
            else
            {
                Console.WriteLine("Failed to connect to the database.");
            }

            return logs;  // Return the list of logs
        }



    }
}
