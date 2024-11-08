using elevator_control_system.Database;
using elevator_control_system.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

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
                    // Create a DataTable to hold the new log data
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("date", typeof(string));
                    dataTable.Columns.Add("requested_at", typeof(TimeSpan));
                    dataTable.Columns.Add("action", typeof(string));

                    // Add a row to the DataTable
                    dataTable.Rows.Add(log.Date.ToString("yyyy-MM-dd"), log.RequestedAt, log.Action);

                    // Create the SQL query for inserting data
                    string query = "INSERT INTO elevator_logs (date, requested_at, action) VALUES (@date, @requestedAt, @action)";

                    // Create a DataAdapter and set the InsertCommand
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter())
                    {
                        dataAdapter.InsertCommand = new MySqlCommand(query, conn);
                        dataAdapter.InsertCommand.Parameters.AddWithValue("@date", log.Date.ToString("yyyy-MM-dd"));
                        dataAdapter.InsertCommand.Parameters.AddWithValue("@requestedAt", log.RequestedAt);
                        dataAdapter.InsertCommand.Parameters.AddWithValue("@action", log.Action);

                        // Use DataAdapter to insert the data into the database
                        int result = dataAdapter.Update(dataTable);  // This will apply the changes to the database

                        if (result > 0)
                        {
                            Console.WriteLine("Elevator log inserted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to insert elevator log.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error inserting elevator log: " + ex.Message);
                }
                finally
                {
                    // Close the database connection after use
                    db.Close(conn);
                }
            }
            else
            {
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

                    // Create a DataAdapter to execute the query
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);

                    // Create a DataTable to hold the fetched data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the query
                    dataAdapter.Fill(dataTable);

                    // Read each row from the DataTable and convert it to an ElevatorLog object
                    foreach (DataRow row in dataTable.Rows)
                    {
                        ElevatorLog log = new ElevatorLog
                        {
                            LogsId = Convert.ToInt32(row["logs_id"]),
                            Date = Convert.ToDateTime(row["date"]),
                            RequestedAt = TimeSpan.Parse(row["requested_at"].ToString()),
                            Action = row["action"].ToString()
                        };
                        logs.Add(log);  // Add the log to the list
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching elevator logs: " + ex.Message);
                }
                finally
                {
                    // Close the database connection after use
                    db.Close(conn);
                }
            }
            else
            {
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
