using elevator_control_system.Controllers;
using elevator_control_system.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace elevator_control_system.View
{
    public class DisplayLogs
    {
        private DataGridView logsGridView;

        public DisplayLogs(DataGridView gridView)
        {
            this.logsGridView = gridView;
        }


        public void displayElevatorLogs()
        {
            // Set auto-generate columns to false
            logsGridView.AutoGenerateColumns = false;

            // Clear existing columns
            logsGridView.Columns.Clear();

            // Add Log ID column
            logsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Log ID",
                DataPropertyName = "LogsId",
                Width = 80
            });

            // Add Date column
            logsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Date",
                DataPropertyName = "Date",
                Width = 100
            });

            // Add Requested At column
            logsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Requested At",
                DataPropertyName = "RequestedAt",
                Width = 80
            });

            // Add Action column
            logsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Action",
                DataPropertyName = "Action",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Initialize the ElevatorController and get logs
            FetchElevatorLog elevatorController = new FetchElevatorLog();
            List<ElevatorLog> logs = elevatorController.getLatestElevatorLogs();

            // Bind data to DataGridView
            logsGridView.DataSource = logs;
            logsGridView.Refresh();

        }
    }
}
