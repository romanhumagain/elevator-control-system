using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using elevator_control_system.Controllers;
using elevator_control_system.Models;

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

        
        private int doorSpeed = 1; // The speed at which the door moves

        private bool isGroundFloorDoorOpening = false;
        private bool isGroundFloorDoorClosing = false;


        private bool isFirstFloorDoorOpening = false;
        private bool isFirstFloorDoorClosing = false;


        private int leftDoorInitialX;
        private int rightDoorInitialX;
        private int doorOpenMaxDistance = 60; 

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
                Width = 50
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void firstFloorBtn_Click(object sender, EventArgs e)
        {
            isMovingToFirstFloor = true;
            isMovingToGroundFloor = false;
            groundFloorBtn.Enabled = false;
            liftTimer.Start();

            // calling function to insert logs to the database
            insertElevatorLogs("Elevator is moving to the First floor");

            // to show the newly recorded logs
            fetchLatestElevatorLogs();
        }

        private void groundFloorBtn_Click(object sender, EventArgs e)
        {
            if (!isAtGroundFloor)
            {
                isMovingToGroundFloor = true;
                isMovingToFirstFloor = false;
                firstFloorBtn.Enabled = false;
                liftTimer.Start();

                // calling function to insert logs to the database
                insertElevatorLogs("Elevator is moving to the Ground floor");

                // to show the newly recorded logs
                fetchLatestElevatorLogs();
            }
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
        }

        private void disableLiftButton()
        {
            firstFloorBtn.Enabled = false;
            groundFloorBtn.Enabled = false;
        }

        private void liftTimer_Tick(object sender, EventArgs e)
        {
            if (isMovingToFirstFloor && elevator.Top > firstFloorPositionY)
            {
                disableLiftButton();
                isAtGroundFloor = false;

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
                    groundFloorBtn.Enabled = true;
                }
            }
            else if (isMovingToGroundFloor && elevator.Top < groundFloorPositionY)
            {
                disableLiftButton();
                isAtFirstFloor = false;

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
                    firstFloorBtn.Enabled = true;

                    isAtGroundFloor = true;
                    
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
                    }
                }
                else if (isGroundFloorDoorClosing)
                {
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
                    }
                }
            }
            
            else if (isAtFirstFloor)
            {
                if (isFirstFloorDoorOpening)
{
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
    }
}
else if (isFirstFloorDoorClosing)
{
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
    }
}

            }
        }

        private void openElevatorDoor()
        {
            if (isAtGroundFloor)
            {
                isGroundFloorDoorOpening = true;
                isGroundFloorDoorClosing = false;
                doorTimer.Start();
            }
            else if (isAtFirstFloor)
            {
                isFirstFloorDoorOpening = true;
                isFirstFloorDoorClosing = false;
                doorTimer.Start(); 
            }
        }

        private void closeElevatorDoor()
        {
            if (isAtGroundFloor)
            {
                isGroundFloorDoorOpening = false;
                isGroundFloorDoorClosing = true;
                doorTimer.Start();
            }
            else if (isAtFirstFloor)
            {
                isFirstFloorDoorOpening = false;
                isFirstFloorDoorClosing = true; 
                doorTimer.Start();
            }
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
    }
}
