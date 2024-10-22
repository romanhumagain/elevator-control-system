﻿namespace elevator_control_system
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logsGridView = new System.Windows.Forms.DataGridView();
            this.logsLbl = new System.Windows.Forms.Label();
            this.groundFloorDoorPanelL = new System.Windows.Forms.PictureBox();
            this.groundFloorDoorPanelR = new System.Windows.Forms.PictureBox();
            this.doorTimer = new System.Windows.Forms.Timer(this.components);
            this.firstFloorDoorPanelL = new System.Windows.Forms.PictureBox();
            this.firstFloorDoorPanelR = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayBoard)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundFloorDoorPanelL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundFloorDoorPanelR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFloorDoorPanelL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFloorDoorPanelR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // elevator
            // 
            this.elevator.Image = ((System.Drawing.Image)(resources.GetObject("elevator.Image")));
            this.elevator.Location = new System.Drawing.Point(118, 437);
            this.elevator.Name = "elevator";
            this.elevator.Size = new System.Drawing.Size(168, 260);
            this.elevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elevator.TabIndex = 0;
            this.elevator.TabStop = false;
            this.elevator.Click += new System.EventHandler(this.elevator_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(462, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 695);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // displayBoard
            // 
            this.displayBoard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.displayBoard.Location = new System.Drawing.Point(511, 193);
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
            this.firstFloorBtn.Location = new System.Drawing.Point(531, 363);
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
            this.groundFloorBtn.Location = new System.Drawing.Point(531, 448);
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
            this.openDoorBtn.Location = new System.Drawing.Point(495, 547);
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
            this.closeDoorBtn.Location = new System.Drawing.Point(566, 547);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.logsGridView);
            this.panel1.Controls.Add(this.logsLbl);
            this.panel1.Location = new System.Drawing.Point(719, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 506);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logsGridView
            // 
            this.logsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logsGridView.Location = new System.Drawing.Point(22, 68);
            this.logsGridView.Name = "logsGridView";
            this.logsGridView.RowHeadersWidth = 51;
            this.logsGridView.RowTemplate.Height = 24;
            this.logsGridView.Size = new System.Drawing.Size(757, 423);
            this.logsGridView.TabIndex = 1;
            // 
            // logsLbl
            // 
            this.logsLbl.AutoSize = true;
            this.logsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logsLbl.Location = new System.Drawing.Point(280, 17);
            this.logsLbl.Name = "logsLbl";
            this.logsLbl.Size = new System.Drawing.Size(237, 29);
            this.logsLbl.TabIndex = 0;
            this.logsLbl.Text = "Elevator Control logs";
            this.logsLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // groundFloorDoorPanelL
            // 
            this.groundFloorDoorPanelL.Image = ((System.Drawing.Image)(resources.GetObject("groundFloorDoorPanelL.Image")));
            this.groundFloorDoorPanelL.Location = new System.Drawing.Point(111, 437);
            this.groundFloorDoorPanelL.Name = "groundFloorDoorPanelL";
            this.groundFloorDoorPanelL.Size = new System.Drawing.Size(90, 260);
            this.groundFloorDoorPanelL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundFloorDoorPanelL.TabIndex = 8;
            this.groundFloorDoorPanelL.TabStop = false;
            this.groundFloorDoorPanelL.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groundFloorDoorPanelR
            // 
            this.groundFloorDoorPanelR.Image = ((System.Drawing.Image)(resources.GetObject("groundFloorDoorPanelR.Image")));
            this.groundFloorDoorPanelR.Location = new System.Drawing.Point(196, 437);
            this.groundFloorDoorPanelR.Name = "groundFloorDoorPanelR";
            this.groundFloorDoorPanelR.Size = new System.Drawing.Size(90, 260);
            this.groundFloorDoorPanelR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundFloorDoorPanelR.TabIndex = 10;
            this.groundFloorDoorPanelR.TabStop = false;
            this.groundFloorDoorPanelR.Click += new System.EventHandler(this.groundFloorDoorPanelR_Click);
            // 
            // doorTimer
            // 
            this.doorTimer.Tick += new System.EventHandler(this.doorTimer_Tick);
            // 
            // firstFloorDoorPanelL
            // 
            this.firstFloorDoorPanelL.Image = ((System.Drawing.Image)(resources.GetObject("firstFloorDoorPanelL.Image")));
            this.firstFloorDoorPanelL.Location = new System.Drawing.Point(111, 28);
            this.firstFloorDoorPanelL.Name = "firstFloorDoorPanelL";
            this.firstFloorDoorPanelL.Size = new System.Drawing.Size(90, 260);
            this.firstFloorDoorPanelL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstFloorDoorPanelL.TabIndex = 11;
            this.firstFloorDoorPanelL.TabStop = false;
            this.firstFloorDoorPanelL.Click += new System.EventHandler(this.firstFloorDoorPanelL_Click);
            // 
            // firstFloorDoorPanelR
            // 
            this.firstFloorDoorPanelR.Image = ((System.Drawing.Image)(resources.GetObject("firstFloorDoorPanelR.Image")));
            this.firstFloorDoorPanelR.Location = new System.Drawing.Point(196, 28);
            this.firstFloorDoorPanelR.Name = "firstFloorDoorPanelR";
            this.firstFloorDoorPanelR.Size = new System.Drawing.Size(90, 260);
            this.firstFloorDoorPanelR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstFloorDoorPanelR.TabIndex = 12;
            this.firstFloorDoorPanelR.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(186, 422);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 20);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(186, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 20);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // Elevator_Control_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1554, 709);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.firstFloorDoorPanelR);
            this.Controls.Add(this.firstFloorDoorPanelL);
            this.Controls.Add(this.groundFloorDoorPanelR);
            this.Controls.Add(this.groundFloorDoorPanelL);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundFloorDoorPanelL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundFloorDoorPanelR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFloorDoorPanelL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFloorDoorPanelR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label logsLbl;
        private System.Windows.Forms.DataGridView logsGridView;
        private System.Windows.Forms.PictureBox groundFloorDoorPanelL;
        private System.Windows.Forms.PictureBox groundFloorDoorPanelR;
        private System.Windows.Forms.Timer doorTimer;
        private System.Windows.Forms.PictureBox firstFloorDoorPanelL;
        private System.Windows.Forms.PictureBox firstFloorDoorPanelR;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

