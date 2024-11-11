using elevator_control_system.Database;
using elevator_control_system.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace elevator_control_system.Controllers
{
    internal class FetchElevatorLog
    {
        private DatabaseConnection db = new DatabaseConnection();  // Database connection instance

        // Method to fetch the latest elevator logs from the database
        public List<ElevatorLog> getLatestElevatorLogs()
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

                        //The properties of the ElevatorLog object are populated with data from the row
                        ElevatorLog log = new ElevatorLog
                        {
                            LogsId = Convert.ToInt32(row["logs_id"]), // logsId is assigned converting logs_id column value to integer 
                            Date = Convert.ToDateTime(row["date"]),
                            RequestedAt = TimeSpan.Parse(row["requested_at"].ToString()),
                            Action = row["action"].ToString()
                        };
                        logs.Add(log);  // Add the log object to the list
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

    }
}
