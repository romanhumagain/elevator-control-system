using elevator_control_system.Database;
using elevator_control_system.Models;
using MySqlConnector;
using System;
using System.Data;

namespace elevator_control_system.Controllers
{
    internal class InsertElevatorLog
    {

        private DatabaseConnection db = new DatabaseConnection();  // Database connection instance

        // Method to insert a new log into the database
        public void insertElevatorLog(ElevatorLog log)
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

                        // prepares SQL insert command with parameter, applies it to a datatable
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

    }
}
