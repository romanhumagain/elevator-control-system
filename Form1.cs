﻿using elevator_control_system.Controllers;
using elevator_control_system.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevator_control_system
{
    public partial class Elevator_Control_System : Form
    {
        int liftSpeed = 5;
        bool isMovingToFirstFloor = false;
        bool isMovingToGroundFloor = false;

        // to check whether the elevator is in the ground floor or first floor
        bool isAtGroundFloor = true;
        bool isAtFirstFloor = false;

        int firstFloorPositionY = 23;
        int groundFloorPositionY = 355;

        private int doorSpeed = 1;

        private bool isGroundFloorDoorOpening = false;
        private bool isGroundFloorDoorClosing = false;


        private bool isFirstFloorDoorOpening = false;
        private bool isFirstFloorDoorClosing = false;


        private int leftDoorInitialX;
        private int rightDoorInitialX;
        private int doorOpenMaxDistance = 68;

        private bool isDoorClosed = false;

        public Elevator_Control_System()
        {
            InitializeComponent();
            elevator.Top = groundFloorPositionY;
            fetchLatestElevatorLogs();

            // Initialize door timer
            doorTimer.Interval = 30;  // Set timer interval in milliseconds
            doorTimer.Tick += new EventHandler(doorTimer_Tick);  // Attach tick event
            leftDoorInitialX = groundFloorDoorPanelL.Left;
            rightDoorInitialX = groundFloorDoorPanelR.Left;
        }

        // Methods to insert the elevator logs
        public void insertElevatorLogs(string action_details)
        {
            ElevatorLog newLog = new ElevatorLog
            {
                Date = DateTime.Now,
                RequestedAt = DateTime.Now.TimeOfDay,
                Action = action_details
            };
            ElevatorController elevatorController = new ElevatorController();
            elevatorController.InsertElevatorLog(newLog);
        }

        // Methods to fetch the elevator logs
        private void fetchLatestElevatorLogs()
        {
            // to set the auto generate columns to be false
            logsGridView.AutoGenerateColumns = false;

            logsGridView.Columns.Clear();

            // to add new column named Logs Id
            logsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Log ID",
                DataPropertyName = "LogsId",
                Width = 80
            });

            // to add new column named Date
            logsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Date",
                DataPropertyName = "Date",
                Width = 100
            });

            // to add new column named Requested At
            logsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Requested At",
                DataPropertyName = "RequestedAt",
                Width = 80
            });

            // to add new column named Action
            logsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Action",
                DataPropertyName = "Action",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            ElevatorController elevatorController = new ElevatorController();
            List<ElevatorLog> logs = elevatorController.GetLatestElevatorLogs();
            logsGridView.DataSource = logs;
            logsGridView.Refresh();
        }

        // method to clear logs
        private void clearLogs()
        {
            ElevatorController elevatorController = new ElevatorController();
            bool isLogsCleared = elevatorController.ClearLogs();

            if (isLogsCleared)
            {
                fetchLatestElevatorLogs();
                //MessageBox.Show("Logs cleared successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);//
            }
            else
            {
                MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void firstFloorBtn_Click(object sender, EventArgs e)
        {
            bool isDoorClosed = closeDoorBeforeMoving();

            if (isDoorClosed)
            {
                isMovingToFirstFloor = true;
                isMovingToGroundFloor = false;
                groundFloorBtn.Enabled = false;
                liftTimer.Start();

                // calling function to insert logs to the database
                insertElevatorLogs("Elevator is moving to the First floor");
                fetchLatestElevatorLogs();


            }
        }

        private void groundFloorBtn_Click(object sender, EventArgs e)
        {
            isMovingToGroundFloor = true;
            isMovingToFirstFloor = false;
            firstFloorBtn.Enabled = false;
            liftTimer.Start();

            // calling function to insert logs to the database
            insertElevatorLogs("Elevator is moving to the Ground floor");
            fetchLatestElevatorLogs();

        }

        private void openDoorBtn_Click(object sender, EventArgs e)
        {
            openElevatorDoor();
        }

        private void closeDoorBtn_Click(object sender, EventArgs e)
        {
            closeElevatorDoor();
        }

        private void displayBoard_Click(object sender, EventArgs e)
        {
        }

        private void elevator_Click(object sender, EventArgs e)
        {
        }

        private void enableLiftButton()
        {
            firstFloorBtn.Enabled = true;
            groundFloorBtn.Enabled = true;
            clearLogsButton.Enabled = true;
            requestFirstFloorBtn.Enabled = true;
            requestGroundBtn.Enabled = true;

        }

        private void disableLiftButton()
        {
            firstFloorBtn.Enabled = false;
            groundFloorBtn.Enabled = false;
            clearLogsButton.Enabled = false;
            requestFirstFloorBtn.Enabled = false;
            requestGroundBtn.Enabled = false;
        }

        // to disable the lift door button
        private void disableDoorButton()
        {
            openDoorBtn.Enabled = false;
            closeDoorBtn.Enabled = false;

        }

        // to disable the lift door button
        private void enableDoorButton()
        {
            openDoorBtn.Enabled = true;
            closeDoorBtn.Enabled = true;
        }

        private void liftTimer_Tick(object sender, EventArgs e)
        {
            if (isMovingToFirstFloor && elevator.Top > firstFloorPositionY)
            {
                bool isDoorClosed = closeDoorBeforeMoving();

                disableLiftButton();
                disableDoorButton();
                isAtGroundFloor = false;

                doorDisplayF.Image = null;
                doorDisplayG.Image = null;

                displayBoard.Image = Image.FromFile(@"D:\University_Assignment\C#\elevator_control_system\Resources\up_indicator_gif.gif");
                displayBoard.SizeMode = PictureBoxSizeMode.StretchImage;

                firstFloorBtn.BackColor = Color.Green;
                groundFloorBtn.BackColor = Color.White;

                elevator.Top -= liftSpeed;

                if (elevator.Top <= firstFloorPositionY)
                {
                    displayBoard.Image = Image.FromFile(@"D:\University_Assignment\C#\elevator_control_system\Resources\one_floor.png");
                    displayBoard.SizeMode = PictureBoxSizeMode.CenterImage;

                    elevator.Top = firstFloorPositionY;
                    firstFloorBtn.BackColor = Color.Red;
                    isAtFirstFloor = true;
                    liftTimer.Stop();

                    doorDisplayF.Image = Image.FromFile(@"D:\University_Assignment\C#\elevator_control_system\Resources\one_door.png");
                    doorDisplayG.Image = Image.FromFile(@"D:\University_Assignment\C#\elevator_control_system\Resources\one_door.png");

                    doorDisplayF.SizeMode = PictureBoxSizeMode.CenterImage;
                    doorDisplayG.SizeMode = PictureBoxSizeMode.CenterImage;


                    groundFloorBtn.Enabled = true;
                    enableDoorButton();
                    enableLiftButton();

                    // calling function to insert logs to the database
                    insertElevatorLogs("Elevator stops at First floor");

                    // to show the newly recorded logs
                    fetchLatestElevatorLogs();

                    AutomaticOpenCloseDoor();

                }
            }
            else if (isMovingToGroundFloor && elevator.Top < groundFloorPositionY)
            {
                disableLiftButton();
                disableDoorButton();

                isAtFirstFloor = false;

                doorDisplayF.Image = null;
                doorDisplayG.Image = null;

                displayBoard.Image = Image.FromFile(@"D:\University_Assignment\C#\elevator_control_system\Resources\down_indicator.gif");
                displayBoard.SizeMode = PictureBoxSizeMode.StretchImage;

                firstFloorBtn.BackColor = Color.White;
                groundFloorBtn.BackColor = Color.Green;

                elevator.Top += liftSpeed;

                if (elevator.Top >= groundFloorPositionY)
                {
                    displayBoard.Image = Image.FromFile(@"D:\University_Assignment\C#\elevator_control_system\Resources\g_floor.png");
                    displayBoard.SizeMode = PictureBoxSizeMode.CenterImage;

                    elevator.Top = groundFloorPositionY;
                    groundFloorBtn.BackColor = Color.Red;
                    liftTimer.Stop();

                    doorDisplayG.Image = Image.FromFile(@"D:\University_Assignment\C#\elevator_control_system\Resources\g_door.png");
                    doorDisplayF.Image = Image.FromFile(@"D:\University_Assignment\C#\elevator_control_system\Resources\g_door.png");

                    doorDisplayG.SizeMode = PictureBoxSizeMode.CenterImage;
                    doorDisplayF.SizeMode = PictureBoxSizeMode.CenterImage;


                    firstFloorBtn.Enabled = true;

                    isAtGroundFloor = true;
                    enableDoorButton();
                    enableLiftButton();

                    // calling function to insert logs to the database
                    insertElevatorLogs("Elevator stops at Ground floor");

                    // to show the newly recorded logs
                    fetchLatestElevatorLogs();

                    AutomaticOpenCloseDoor();

                }
            }
        }

        // Timer tick event to animate the door
        private void doorTimer_Tick(object sender, EventArgs e)
        {
            if (isAtGroundFloor)
            {
                if (isGroundFloorDoorOpening)
                {
                    closeDoorBtn.Enabled = false;

                    // Move the left door to the left
                    if (groundFloorDoorPanelL.Left > leftDoorInitialX - doorOpenMaxDistance)
                    {
                        groundFloorDoorPanelL.Left -= doorSpeed;
                    }

                    // Move the right door to the right
                    if (groundFloorDoorPanelR.Left < rightDoorInitialX + doorOpenMaxDistance)
                    {
                        groundFloorDoorPanelR.Left += doorSpeed;
                    }

                    // Stop the timer once the door is fully opened
                    if (groundFloorDoorPanelL.Left <= leftDoorInitialX - doorOpenMaxDistance &&
                        groundFloorDoorPanelR.Left >= rightDoorInitialX + doorOpenMaxDistance)
                    {
                        doorTimer.Stop();
                        closeDoorBtn.Enabled = true;
                    }
                }
                else if (isGroundFloorDoorClosing)
                {
                    openDoorBtn.Enabled = false;
                    if (groundFloorDoorPanelL.Left < leftDoorInitialX)
                    {
                        groundFloorDoorPanelL.Left += doorSpeed;
                    }

                    if (groundFloorDoorPanelR.Left > rightDoorInitialX)
                    {
                        groundFloorDoorPanelR.Left -= doorSpeed;
                    }

                    if (groundFloorDoorPanelL.Left >= leftDoorInitialX &&
                        groundFloorDoorPanelR.Left <= rightDoorInitialX)
                    {
                        doorTimer.Stop();
                        openDoorBtn.Enabled = true;

                    }
                }
            }

            else if (isAtFirstFloor)
            {
                if (isFirstFloorDoorOpening)
                {
                    closeDoorBtn.Enabled = false;
                    // Move the left door to the left
                    if (firstFloorDoorPanelL.Left > leftDoorInitialX - doorOpenMaxDistance)
                    {
                        firstFloorDoorPanelL.Left -= doorSpeed;
                    }

                    // Move the right door to the right
                    if (firstFloorDoorPanelR.Left < rightDoorInitialX + doorOpenMaxDistance)
                    {
                        firstFloorDoorPanelR.Left += doorSpeed;
                    }

                    // Stop the timer once the door is fully opened
                    if (firstFloorDoorPanelL.Left <= leftDoorInitialX - doorOpenMaxDistance &&
                        firstFloorDoorPanelR.Left >= rightDoorInitialX + doorOpenMaxDistance)
                    {
                        doorTimer.Stop();
                        closeDoorBtn.Enabled = true;
                    }
                }
                else if (isFirstFloorDoorClosing)
                {
                    openDoorBtn.Enabled = false;
                    if (firstFloorDoorPanelL.Left < leftDoorInitialX)
                    {
                        firstFloorDoorPanelL.Left += doorSpeed;
                    }

                    if (firstFloorDoorPanelR.Left > rightDoorInitialX)
                    {
                        firstFloorDoorPanelR.Left -= doorSpeed;
                    }

                    if (firstFloorDoorPanelL.Left >= leftDoorInitialX &&
                        firstFloorDoorPanelR.Left <= rightDoorInitialX)
                    {
                        doorTimer.Stop();
                        openDoorBtn.Enabled = true;

                    }
                }

            }
        }

        private void openElevatorDoor()
        {
            if (isAtGroundFloor && !isGroundFloorDoorOpening)
            {
                isGroundFloorDoorOpening = true;
                isGroundFloorDoorClosing = false;
                openDoorBtn.BackColor = Color.Gray;
                doorTimer.Start();
                disableLiftButton();

                // calling function to insert logs to the database
                insertElevatorLogs("Door opened at ground floor");
                // to show the newly recorded logs
                fetchLatestElevatorLogs();
            }
            else if (isAtFirstFloor && !isFirstFloorDoorOpening)
            {
                isFirstFloorDoorOpening = true;
                isFirstFloorDoorClosing = false;
                openDoorBtn.BackColor = Color.Gray;
                doorTimer.Start();

                disableLiftButton();

                // calling function to insert logs to the database
                insertElevatorLogs("Door opened at first floor");
                // to show the newly recorded logs
                fetchLatestElevatorLogs();

            }
        }

        private void closeElevatorDoor()
        {
            if (isAtGroundFloor && !isGroundFloorDoorClosing)
            {
                isGroundFloorDoorOpening = false;
                isGroundFloorDoorClosing = true;
                openDoorBtn.BackColor = Color.White;
                doorTimer.Start();
                enableLiftButton();

                // calling function to insert logs to the database
                insertElevatorLogs("Door closed at ground floor");
                // to show the newly recorded logs
                fetchLatestElevatorLogs();
            }
            else if (isAtFirstFloor && !isFirstFloorDoorClosing)
            {
                isFirstFloorDoorOpening = false;
                isFirstFloorDoorClosing = true;
                openDoorBtn.BackColor = Color.White;
                doorTimer.Start();
                enableLiftButton();

                // calling function to insert logs to the database
                insertElevatorLogs("Door closed at first floor");
                // to show the newly recorded logs
                fetchLatestElevatorLogs();

            }
        }


        // to handle closing door before moving elevator
        private bool closeDoorBeforeMoving()
        {
            return true;
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void firstFloorDoorPanelL_Click(object sender, EventArgs e)
        {

        }

        private void groundFloorDoorPanelR_Click(object sender, EventArgs e)
        {

        }

        private void clearLogsButton_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            var result = MessageBox.Show("Are you sure you want to clear the logs?",
                                          "Confirm Clear Logs",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Warning);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                clearLogs();
            }
        }



        private void requestGroundBtn_Click(object sender, EventArgs e)
        {
            if (!isAtFirstFloor)
            {
                isMovingToFirstFloor = true;
                isMovingToGroundFloor = false;
                liftTimer.Start();

                // calling function to insert logs to the database
                insertElevatorLogs("Elevator is requested from the First floor");
                fetchLatestElevatorLogs();
            }

        }

        private void requestFirstFloorBtn_Click(object sender, EventArgs e)
        {
            if (!isAtGroundFloor)
            {
                isMovingToGroundFloor = true;
                isMovingToFirstFloor = false;
                liftTimer.Start();

                // calling function to insert logs to the database
                insertElevatorLogs("Elevator is requested from the Ground floor");
                fetchLatestElevatorLogs();
            }

        }

        private void firstFloorDoorPanelL_Click_1(object sender, EventArgs e)
        {

        }

        // Function to automatically open and close the door
        public async Task AutomaticOpenCloseDoor()
        {
            await Task.Delay(500);

            openElevatorDoor();
            disableLiftButton();

            await Task.Delay(3000);
            closeElevatorDoor();
            enableLiftButton();
        }


    }
}
