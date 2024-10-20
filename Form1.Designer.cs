namespace elevator_control_system
{
    partial class Elevator_Control_System
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elevator_Control_System));
            this.elevator = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.displayBoard = new System.Windows.Forms.PictureBox();
            this.firstFloorBtn = new System.Windows.Forms.Button();
            this.groundFloorBtn = new System.Windows.Forms.Button();
            this.openDoorBtn = new System.Windows.Forms.Button();
            this.closeDoorBtn = new System.Windows.Forms.Button();
            this.liftTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // elevator
            // 
            this.elevator.Image = ((System.Drawing.Image)(resources.GetObject("elevator.Image")));
            this.elevator.Location = new System.Drawing.Point(248, 365);
            this.elevator.Name = "elevator";
            this.elevator.Size = new System.Drawing.Size(151, 254);
            this.elevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elevator.TabIndex = 0;
            this.elevator.TabStop = false;
            this.elevator.Click += new System.EventHandler(this.elevator_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(448, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 607);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // displayBoard
            // 
            this.displayBoard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayBoard.Location = new System.Drawing.Point(496, 91);
            this.displayBoard.Name = "displayBoard";
            this.displayBoard.Size = new System.Drawing.Size(102, 129);
            this.displayBoard.TabIndex = 2;
            this.displayBoard.TabStop = false;
            this.displayBoard.Click += new System.EventHandler(this.displayBoard_Click);
            // 
            // firstFloorBtn
            // 
            this.firstFloorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstFloorBtn.BackgroundImage")));
            this.firstFloorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstFloorBtn.Location = new System.Drawing.Point(526, 305);
            this.firstFloorBtn.Name = "firstFloorBtn";
            this.firstFloorBtn.Size = new System.Drawing.Size(49, 54);
            this.firstFloorBtn.TabIndex = 3;
            this.firstFloorBtn.UseVisualStyleBackColor = true;
            this.firstFloorBtn.Click += new System.EventHandler(this.firstFloorBtn_Click);
            // 
            // groundFloorBtn
            // 
            this.groundFloorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groundFloorBtn.BackgroundImage")));
            this.groundFloorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groundFloorBtn.Location = new System.Drawing.Point(526, 379);
            this.groundFloorBtn.Name = "groundFloorBtn";
            this.groundFloorBtn.Size = new System.Drawing.Size(49, 51);
            this.groundFloorBtn.TabIndex = 4;
            this.groundFloorBtn.UseVisualStyleBackColor = true;
            this.groundFloorBtn.Click += new System.EventHandler(this.groundFloorBtn_Click);
            // 
            // openDoorBtn
            // 
            this.openDoorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openDoorBtn.BackgroundImage")));
            this.openDoorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openDoorBtn.Location = new System.Drawing.Point(496, 469);
            this.openDoorBtn.Name = "openDoorBtn";
            this.openDoorBtn.Size = new System.Drawing.Size(47, 43);
            this.openDoorBtn.TabIndex = 5;
            this.openDoorBtn.UseVisualStyleBackColor = true;
            this.openDoorBtn.Click += new System.EventHandler(this.openDoorBtn_Click);
            // 
            // closeDoorBtn
            // 
            this.closeDoorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeDoorBtn.BackgroundImage")));
            this.closeDoorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeDoorBtn.Location = new System.Drawing.Point(562, 469);
            this.closeDoorBtn.Name = "closeDoorBtn";
            this.closeDoorBtn.Size = new System.Drawing.Size(47, 43);
            this.closeDoorBtn.TabIndex = 6;
            this.closeDoorBtn.UseVisualStyleBackColor = true;
            this.closeDoorBtn.Click += new System.EventHandler(this.closeDoorBtn_Click);
            // 
            // liftTimer
            // 
            this.liftTimer.Tick += new System.EventHandler(this.liftTimer_Tick);
            // 
            // Elevator_Control_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1174, 643);
            this.Controls.Add(this.closeDoorBtn);
            this.Controls.Add(this.openDoorBtn);
            this.Controls.Add(this.groundFloorBtn);
            this.Controls.Add(this.firstFloorBtn);
            this.Controls.Add(this.displayBoard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.elevator);
            this.Name = "Elevator_Control_System";
            this.Text = "Elevator_Control_System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox elevator;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox displayBoard;
        private System.Windows.Forms.Button firstFloorBtn;
        private System.Windows.Forms.Button groundFloorBtn;
        private System.Windows.Forms.Button openDoorBtn;
        private System.Windows.Forms.Button closeDoorBtn;
        private System.Windows.Forms.Timer liftTimer;
    }
}

