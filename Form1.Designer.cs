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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearLogsButton = new System.Windows.Forms.Button();
            this.logsGridView = new System.Windows.Forms.DataGridView();
            this.logsLbl = new System.Windows.Forms.Label();
            this.groundFloorDoorPanelL = new System.Windows.Forms.PictureBox();
            this.groundFloorDoorPanelR = new System.Windows.Forms.PictureBox();
            this.doorTimer = new System.Windows.Forms.Timer(this.components);
            this.doorDisplayG = new System.Windows.Forms.PictureBox();
            this.doorDisplayF = new System.Windows.Forms.PictureBox();
            this.requestFirstBtn = new System.Windows.Forms.Panel();
            this.firstFloorDoorPanelL = new System.Windows.Forms.PictureBox();
            this.firstFloorDoorPanelR = new System.Windows.Forms.PictureBox();
            this.requestGroundBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.requestFirstFloorBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayBoard)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundFloorDoorPanelL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundFloorDoorPanelR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorDisplayG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorDisplayF)).BeginInit();
            this.requestFirstBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstFloorDoorPanelL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFloorDoorPanelR)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // elevator
            // 
            this.elevator.Image = ((System.Drawing.Image)(resources.GetObject("elevator.Image")));
            this.elevator.Location = new System.Drawing.Point(107, 435);
            this.elevator.Name = "elevator";
            this.elevator.Size = new System.Drawing.Size(192, 260);
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
            this.pictureBox1.Size = new System.Drawing.Size(195, 717);
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
            this.panel1.Controls.Add(this.clearLogsButton);
            this.panel1.Controls.Add(this.logsGridView);
            this.panel1.Controls.Add(this.logsLbl);
            this.panel1.Location = new System.Drawing.Point(719, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 549);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // clearLogsButton
            // 
            this.clearLogsButton.BackColor = System.Drawing.Color.Red;
            this.clearLogsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearLogsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearLogsButton.Location = new System.Drawing.Point(337, 49);
            this.clearLogsButton.Name = "clearLogsButton";
            this.clearLogsButton.Size = new System.Drawing.Size(118, 36);
            this.clearLogsButton.TabIndex = 2;
            this.clearLogsButton.Text = "Clear Logs";
            this.clearLogsButton.UseVisualStyleBackColor = false;
            this.clearLogsButton.Click += new System.EventHandler(this.clearLogsButton_Click);
            // 
            // logsGridView
            // 
            this.logsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logsGridView.Location = new System.Drawing.Point(21, 91);
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
            this.groundFloorDoorPanelL.Location = new System.Drawing.Point(100, 435);
            this.groundFloorDoorPanelL.Name = "groundFloorDoorPanelL";
            this.groundFloorDoorPanelL.Size = new System.Drawing.Size(103, 269);
            this.groundFloorDoorPanelL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundFloorDoorPanelL.TabIndex = 8;
            this.groundFloorDoorPanelL.TabStop = false;
            this.groundFloorDoorPanelL.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // groundFloorDoorPanelR
            // 
            this.groundFloorDoorPanelR.Image = ((System.Drawing.Image)(resources.GetObject("groundFloorDoorPanelR.Image")));
            this.groundFloorDoorPanelR.Location = new System.Drawing.Point(200, 435);
            this.groundFloorDoorPanelR.Name = "groundFloorDoorPanelR";
            this.groundFloorDoorPanelR.Size = new System.Drawing.Size(104, 269);
            this.groundFloorDoorPanelR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.groundFloorDoorPanelR.TabIndex = 10;
            this.groundFloorDoorPanelR.TabStop = false;
            this.groundFloorDoorPanelR.Click += new System.EventHandler(this.groundFloorDoorPanelR_Click);
            // 
            // doorTimer
            // 
            this.doorTimer.Tick += new System.EventHandler(this.doorTimer_Tick);
            // 
            // doorDisplayG
            // 
            this.doorDisplayG.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doorDisplayG.Location = new System.Drawing.Point(181, 409);
            this.doorDisplayG.Name = "doorDisplayG";
            this.doorDisplayG.Size = new System.Drawing.Size(43, 20);
            this.doorDisplayG.TabIndex = 13;
            this.doorDisplayG.TabStop = false;
            // 
            // doorDisplayF
            // 
            this.doorDisplayF.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doorDisplayF.Location = new System.Drawing.Point(181, 10);
            this.doorDisplayF.Name = "doorDisplayF";
            this.doorDisplayF.Size = new System.Drawing.Size(43, 20);
            this.doorDisplayF.TabIndex = 14;
            this.doorDisplayF.TabStop = false;
            // 
            // requestFirstBtn
            // 
            this.requestFirstBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.requestFirstBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.requestFirstBtn.Controls.Add(this.panel5);
            this.requestFirstBtn.Controls.Add(this.panel3);
            this.requestFirstBtn.Controls.Add(this.panel2);
            this.requestFirstBtn.Controls.Add(this.firstFloorDoorPanelR);
            this.requestFirstBtn.Controls.Add(this.firstFloorDoorPanelL);
            this.requestFirstBtn.Controls.Add(this.doorDisplayF);
            this.requestFirstBtn.Controls.Add(this.groundFloorDoorPanelL);
            this.requestFirstBtn.Controls.Add(this.doorDisplayG);
            this.requestFirstBtn.Controls.Add(this.groundFloorDoorPanelR);
            this.requestFirstBtn.Controls.Add(this.elevator);
            this.requestFirstBtn.Location = new System.Drawing.Point(12, 2);
            this.requestFirstBtn.Name = "requestFirstBtn";
            this.requestFirstBtn.Size = new System.Drawing.Size(430, 717);
            this.requestFirstBtn.TabIndex = 16;
            // 
            // firstFloorDoorPanelL
            // 
            this.firstFloorDoorPanelL.Image = ((System.Drawing.Image)(resources.GetObject("firstFloorDoorPanelL.Image")));
            this.firstFloorDoorPanelL.Location = new System.Drawing.Point(100, 28);
            this.firstFloorDoorPanelL.Name = "firstFloorDoorPanelL";
            this.firstFloorDoorPanelL.Size = new System.Drawing.Size(103, 267);
            this.firstFloorDoorPanelL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstFloorDoorPanelL.TabIndex = 11;
            this.firstFloorDoorPanelL.TabStop = false;
            this.firstFloorDoorPanelL.Click += new System.EventHandler(this.firstFloorDoorPanelL_Click_1);
            // 
            // firstFloorDoorPanelR
            // 
            this.firstFloorDoorPanelR.Image = ((System.Drawing.Image)(resources.GetObject("firstFloorDoorPanelR.Image")));
            this.firstFloorDoorPanelR.Location = new System.Drawing.Point(200, 28);
            this.firstFloorDoorPanelR.Name = "firstFloorDoorPanelR";
            this.firstFloorDoorPanelR.Size = new System.Drawing.Size(104, 267);
            this.firstFloorDoorPanelR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.firstFloorDoorPanelR.TabIndex = 12;
            this.firstFloorDoorPanelR.TabStop = false;
            // 
            // requestGroundBtn
            // 
            this.requestGroundBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("requestGroundBtn.BackgroundImage")));
            this.requestGroundBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.requestGroundBtn.Location = new System.Drawing.Point(9, 108);
            this.requestGroundBtn.Name = "requestGroundBtn";
            this.requestGroundBtn.Size = new System.Drawing.Size(48, 55);
            this.requestGroundBtn.TabIndex = 16;
            this.requestGroundBtn.UseVisualStyleBackColor = true;
            this.requestGroundBtn.Click += new System.EventHandler(this.requestGroundBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.requestFirstFloorBtn);
            this.panel2.Location = new System.Drawing.Point(305, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 269);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(0, 435);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(101, 269);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(12, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(101, 275);
            this.panel4.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.requestGroundBtn);
            this.panel5.Location = new System.Drawing.Point(301, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(129, 267);
            this.panel5.TabIndex = 20;
            // 
            // requestFirstFloorBtn
            // 
            this.requestFirstFloorBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("requestFirstFloorBtn.BackgroundImage")));
            this.requestFirstFloorBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.requestFirstFloorBtn.Location = new System.Drawing.Point(5, 100);
            this.requestFirstFloorBtn.Name = "requestFirstFloorBtn";
            this.requestFirstFloorBtn.Size = new System.Drawing.Size(48, 53);
            this.requestFirstFloorBtn.TabIndex = 0;
            this.requestFirstFloorBtn.UseVisualStyleBackColor = true;
            this.requestFirstFloorBtn.Click += new System.EventHandler(this.requestFirstFloorBtn_Click);
            // 
            // Elevator_Control_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1575, 755);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.requestFirstBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closeDoorBtn);
            this.Controls.Add(this.openDoorBtn);
            this.Controls.Add(this.groundFloorBtn);
            this.Controls.Add(this.firstFloorBtn);
            this.Controls.Add(this.displayBoard);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.doorDisplayG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doorDisplayF)).EndInit();
            this.requestFirstBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.firstFloorDoorPanelL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstFloorDoorPanelR)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox doorDisplayG;
        private System.Windows.Forms.PictureBox doorDisplayF;
        private System.Windows.Forms.Button clearLogsButton;
        private System.Windows.Forms.Panel requestFirstBtn;
        private System.Windows.Forms.PictureBox firstFloorDoorPanelR;
        private System.Windows.Forms.PictureBox firstFloorDoorPanelL;
        private System.Windows.Forms.Button requestGroundBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button requestFirstFloorBtn;
    }
}

