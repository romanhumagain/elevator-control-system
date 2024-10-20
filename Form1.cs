using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using elevator_control_system.Controllers;
using elevator_control_system.Models;


namespace elevator_control_system
{
    public partial class Elevator_Control_System : Form
    {
        int liftSpeed = 10;
        bool isMovingToFirstFloor = false;
        bool isMovingToGroundFloor = false;
        bool isAtGroundFloor = true;

        int firstFloorPositionY = 20;
        int groundFloorPositionY = 300;

        public Elevator_Control_System()
        {
            InitializeComponent();
            elevator.Top = groundFloorPositionY;
        }

        public void insertElevatorLogs(string action_details)
        {

            ElevatorLog newLog = new ElevatorLog
            {
                Date = DateTime.Now,
                RequestedAt = DateTime.Now.TimeOfDay,
                Action = action_details
            };
            ElevatorController elevatorContoller = new ElevatorController();

            elevatorContoller.InsertElevatorLog(newLog);
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
            }
        }

        private void openDoorBtn_Click(object sender, EventArgs e)
        {
        }

        private void closeDoorBtn_Click(object sender, EventArgs e)
        {
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
                    isAtGroundFloor = false;
                    liftTimer.Stop();
                    groundFloorBtn.Enabled = true;
                    
                }
            }
            else if (isMovingToGroundFloor && elevator.Top < groundFloorPositionY)
            {
                disableLiftButton();
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

                }
            }
        }
    }
}