namespace unicyclegame
{
    partial class MainForm
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startCounterLabel = new System.Windows.Forms.Label();
            this.unicycle = new System.Windows.Forms.PictureBox();
            this.restart = new System.Windows.Forms.Button();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.vibOffButton = new System.Windows.Forms.Button();
            this.label_Message = new System.Windows.Forms.Label();
            this.createDeviceButton = new System.Windows.Forms.Button();
            this.label_XAxis = new System.Windows.Forms.Label();
            this.label_YAxis = new System.Windows.Forms.Label();
            this.label_ZAxis = new System.Windows.Forms.Label();
            this.label_XRotation = new System.Windows.Forms.Label();
            this.label_YRotation = new System.Windows.Forms.Label();
            this.label_ZRotation = new System.Windows.Forms.Label();
            this.label_Buttons = new System.Windows.Forms.Label();
            this.label_ButtonList = new System.Windows.Forms.Label();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label_Z = new System.Windows.Forms.Label();
            this.label_XRot = new System.Windows.Forms.Label();
            this.label_YRot = new System.Windows.Forms.Label();
            this.label_ZRot = new System.Windows.Forms.Label();
            this.label_Slider0 = new System.Windows.Forms.Label();
            this.label_Slider1 = new System.Windows.Forms.Label();
            this.label_POV0 = new System.Windows.Forms.Label();
            this.label_POV1 = new System.Windows.Forms.Label();
            this.label_POV2 = new System.Windows.Forms.Label();
            this.label_POV3 = new System.Windows.Forms.Label();
            this.label_S0 = new System.Windows.Forms.Label();
            this.label_S1 = new System.Windows.Forms.Label();
            this.label_P0 = new System.Windows.Forms.Label();
            this.label_P1 = new System.Windows.Forms.Label();
            this.label_P2 = new System.Windows.Forms.Label();
            this.label_P3 = new System.Windows.Forms.Label();
            this.noiseLabel = new System.Windows.Forms.Label();
            this.groupBox_JoystickState = new System.Windows.Forms.GroupBox();
            this.scoreLabelLabel = new System.Windows.Forms.Label();
            this.blockPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unicycle)).BeginInit();
            this.groupBox_JoystickState.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1007, 544);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.blockPanel);
            this.panel1.Controls.Add(this.startCounterLabel);
            this.panel1.Controls.Add(this.unicycle);
            this.panel1.Location = new System.Drawing.Point(11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 521);
            this.panel1.TabIndex = 7;
            // 
            // startCounterLabel
            // 
            this.startCounterLabel.AutoSize = true;
            this.startCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.startCounterLabel.Font = new System.Drawing.Font("Comic Sans MS", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCounterLabel.Location = new System.Drawing.Point(498, 187);
            this.startCounterLabel.Name = "startCounterLabel";
            this.startCounterLabel.Size = new System.Drawing.Size(112, 130);
            this.startCounterLabel.TabIndex = 2;
            this.startCounterLabel.Text = "3";
            this.startCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // unicycle
            // 
            this.unicycle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.unicycle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unicycle.Image = global::unicyclegame.Properties.Resources.fatlady;
            this.unicycle.InitialImage = global::unicyclegame.Properties.Resources.fatlady;
            this.unicycle.Location = new System.Drawing.Point(0, 0);
            this.unicycle.Name = "unicycle";
            this.unicycle.Size = new System.Drawing.Size(1071, 521);
            this.unicycle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.unicycle.TabIndex = 1;
            this.unicycle.TabStop = false;
            this.unicycle.Click += new System.EventHandler(this.unicycle_Click);
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(12, 539);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 8;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyLabel.Location = new System.Drawing.Point(254, 547);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(49, 23);
            this.difficultyLabel.TabIndex = 34;
            this.difficultyLabel.Text = "1";
            this.difficultyLabel.Click += new System.EventHandler(this.difficultyLabel_Click);
            // 
            // vibOffButton
            // 
            this.vibOffButton.Location = new System.Drawing.Point(93, 539);
            this.vibOffButton.Name = "vibOffButton";
            this.vibOffButton.Size = new System.Drawing.Size(75, 23);
            this.vibOffButton.TabIndex = 35;
            this.vibOffButton.Text = "VIbration Off";
            this.vibOffButton.UseVisualStyleBackColor = true;
            this.vibOffButton.Click += new System.EventHandler(this.vibOffButton_Click);
            // 
            // label_Message
            // 
            this.label_Message.Location = new System.Drawing.Point(1156, 12);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(258, 55);
            this.label_Message.TabIndex = 3;
            this.label_Message.Text = "This sample polls the joystick for data.\r\n\r\nWhen in immediate mode, joystick data" +
    " is lost\r\nbetween updates.";
            // 
            // createDeviceButton
            // 
            this.createDeviceButton.Location = new System.Drawing.Point(1156, 293);
            this.createDeviceButton.Name = "createDeviceButton";
            this.createDeviceButton.Size = new System.Drawing.Size(89, 23);
            this.createDeviceButton.TabIndex = 6;
            this.createDeviceButton.Text = "Create Device";
            this.createDeviceButton.UseVisualStyleBackColor = true;
            this.createDeviceButton.Click += new System.EventHandler(this.createDeviceButton_Click);
            // 
            // label_XAxis
            // 
            this.label_XAxis.AutoSize = true;
            this.label_XAxis.Enabled = false;
            this.label_XAxis.Location = new System.Drawing.Point(9, 16);
            this.label_XAxis.Name = "label_XAxis";
            this.label_XAxis.Size = new System.Drawing.Size(39, 13);
            this.label_XAxis.TabIndex = 26;
            this.label_XAxis.Text = "X Axis:";
            // 
            // label_YAxis
            // 
            this.label_YAxis.AutoSize = true;
            this.label_YAxis.Enabled = false;
            this.label_YAxis.Location = new System.Drawing.Point(9, 34);
            this.label_YAxis.Name = "label_YAxis";
            this.label_YAxis.Size = new System.Drawing.Size(39, 13);
            this.label_YAxis.TabIndex = 27;
            this.label_YAxis.Text = "Y Axis:";
            // 
            // label_ZAxis
            // 
            this.label_ZAxis.AutoSize = true;
            this.label_ZAxis.Enabled = false;
            this.label_ZAxis.Location = new System.Drawing.Point(9, 53);
            this.label_ZAxis.Name = "label_ZAxis";
            this.label_ZAxis.Size = new System.Drawing.Size(39, 13);
            this.label_ZAxis.TabIndex = 28;
            this.label_ZAxis.Text = "Z Axis:";
            // 
            // label_XRotation
            // 
            this.label_XRotation.AutoSize = true;
            this.label_XRotation.Enabled = false;
            this.label_XRotation.Location = new System.Drawing.Point(9, 83);
            this.label_XRotation.Name = "label_XRotation";
            this.label_XRotation.Size = new System.Drawing.Size(60, 13);
            this.label_XRotation.TabIndex = 29;
            this.label_XRotation.Text = "X Rotation:";
            // 
            // label_YRotation
            // 
            this.label_YRotation.AutoSize = true;
            this.label_YRotation.Enabled = false;
            this.label_YRotation.Location = new System.Drawing.Point(9, 102);
            this.label_YRotation.Name = "label_YRotation";
            this.label_YRotation.Size = new System.Drawing.Size(60, 13);
            this.label_YRotation.TabIndex = 30;
            this.label_YRotation.Text = "Y Rotation:";
            // 
            // label_ZRotation
            // 
            this.label_ZRotation.AutoSize = true;
            this.label_ZRotation.Enabled = false;
            this.label_ZRotation.Location = new System.Drawing.Point(9, 123);
            this.label_ZRotation.Name = "label_ZRotation";
            this.label_ZRotation.Size = new System.Drawing.Size(60, 13);
            this.label_ZRotation.TabIndex = 31;
            this.label_ZRotation.Text = "Z Rotation:";
            // 
            // label_Buttons
            // 
            this.label_Buttons.AutoSize = true;
            this.label_Buttons.Location = new System.Drawing.Point(9, 159);
            this.label_Buttons.Name = "label_Buttons";
            this.label_Buttons.Size = new System.Drawing.Size(52, 13);
            this.label_Buttons.TabIndex = 32;
            this.label_Buttons.Text = "Button(s):";
            // 
            // label_ButtonList
            // 
            this.label_ButtonList.Location = new System.Drawing.Point(67, 159);
            this.label_ButtonList.Name = "label_ButtonList";
            this.label_ButtonList.Size = new System.Drawing.Size(191, 23);
            this.label_ButtonList.TabIndex = 33;
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.Enabled = false;
            this.label_X.Location = new System.Drawing.Point(78, 16);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(13, 13);
            this.label_X.TabIndex = 34;
            this.label_X.Text = "0";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.Enabled = false;
            this.label_Y.Location = new System.Drawing.Point(78, 34);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(13, 13);
            this.label_Y.TabIndex = 35;
            this.label_Y.Text = "0";
            // 
            // label_Z
            // 
            this.label_Z.AutoSize = true;
            this.label_Z.Enabled = false;
            this.label_Z.Location = new System.Drawing.Point(78, 53);
            this.label_Z.Name = "label_Z";
            this.label_Z.Size = new System.Drawing.Size(13, 13);
            this.label_Z.TabIndex = 36;
            this.label_Z.Text = "0";
            // 
            // label_XRot
            // 
            this.label_XRot.AutoSize = true;
            this.label_XRot.Enabled = false;
            this.label_XRot.Location = new System.Drawing.Point(78, 83);
            this.label_XRot.Name = "label_XRot";
            this.label_XRot.Size = new System.Drawing.Size(13, 13);
            this.label_XRot.TabIndex = 37;
            this.label_XRot.Text = "0";
            // 
            // label_YRot
            // 
            this.label_YRot.AutoSize = true;
            this.label_YRot.Enabled = false;
            this.label_YRot.Location = new System.Drawing.Point(78, 102);
            this.label_YRot.Name = "label_YRot";
            this.label_YRot.Size = new System.Drawing.Size(13, 13);
            this.label_YRot.TabIndex = 38;
            this.label_YRot.Text = "0";
            // 
            // label_ZRot
            // 
            this.label_ZRot.AutoSize = true;
            this.label_ZRot.Enabled = false;
            this.label_ZRot.Location = new System.Drawing.Point(78, 123);
            this.label_ZRot.Name = "label_ZRot";
            this.label_ZRot.Size = new System.Drawing.Size(13, 13);
            this.label_ZRot.TabIndex = 39;
            this.label_ZRot.Text = "0";
            // 
            // label_Slider0
            // 
            this.label_Slider0.AutoSize = true;
            this.label_Slider0.Enabled = false;
            this.label_Slider0.Location = new System.Drawing.Point(136, 16);
            this.label_Slider0.Name = "label_Slider0";
            this.label_Slider0.Size = new System.Drawing.Size(45, 13);
            this.label_Slider0.TabIndex = 40;
            this.label_Slider0.Text = "Slider 0:";
            // 
            // label_Slider1
            // 
            this.label_Slider1.AutoSize = true;
            this.label_Slider1.Enabled = false;
            this.label_Slider1.Location = new System.Drawing.Point(136, 34);
            this.label_Slider1.Name = "label_Slider1";
            this.label_Slider1.Size = new System.Drawing.Size(45, 13);
            this.label_Slider1.TabIndex = 41;
            this.label_Slider1.Text = "Slider 1:";
            // 
            // label_POV0
            // 
            this.label_POV0.AutoSize = true;
            this.label_POV0.Enabled = false;
            this.label_POV0.Location = new System.Drawing.Point(136, 63);
            this.label_POV0.Name = "label_POV0";
            this.label_POV0.Size = new System.Drawing.Size(41, 13);
            this.label_POV0.TabIndex = 42;
            this.label_POV0.Text = "POV 0:";
            // 
            // label_POV1
            // 
            this.label_POV1.AutoSize = true;
            this.label_POV1.Enabled = false;
            this.label_POV1.Location = new System.Drawing.Point(136, 83);
            this.label_POV1.Name = "label_POV1";
            this.label_POV1.Size = new System.Drawing.Size(41, 13);
            this.label_POV1.TabIndex = 43;
            this.label_POV1.Text = "POV 1:";
            // 
            // label_POV2
            // 
            this.label_POV2.AutoSize = true;
            this.label_POV2.Enabled = false;
            this.label_POV2.Location = new System.Drawing.Point(136, 102);
            this.label_POV2.Name = "label_POV2";
            this.label_POV2.Size = new System.Drawing.Size(41, 13);
            this.label_POV2.TabIndex = 44;
            this.label_POV2.Text = "POV 2:";
            // 
            // label_POV3
            // 
            this.label_POV3.AutoSize = true;
            this.label_POV3.Enabled = false;
            this.label_POV3.Location = new System.Drawing.Point(136, 121);
            this.label_POV3.Name = "label_POV3";
            this.label_POV3.Size = new System.Drawing.Size(41, 13);
            this.label_POV3.TabIndex = 45;
            this.label_POV3.Text = "POV 3:";
            // 
            // label_S0
            // 
            this.label_S0.AutoSize = true;
            this.label_S0.Enabled = false;
            this.label_S0.Location = new System.Drawing.Point(196, 16);
            this.label_S0.Name = "label_S0";
            this.label_S0.Size = new System.Drawing.Size(13, 13);
            this.label_S0.TabIndex = 46;
            this.label_S0.Text = "0";
            // 
            // label_S1
            // 
            this.label_S1.AutoSize = true;
            this.label_S1.Enabled = false;
            this.label_S1.Location = new System.Drawing.Point(196, 34);
            this.label_S1.Name = "label_S1";
            this.label_S1.Size = new System.Drawing.Size(13, 13);
            this.label_S1.TabIndex = 47;
            this.label_S1.Text = "0";
            // 
            // label_P0
            // 
            this.label_P0.AutoSize = true;
            this.label_P0.Enabled = false;
            this.label_P0.Location = new System.Drawing.Point(196, 63);
            this.label_P0.Name = "label_P0";
            this.label_P0.Size = new System.Drawing.Size(16, 13);
            this.label_P0.TabIndex = 48;
            this.label_P0.Text = "-1";
            // 
            // label_P1
            // 
            this.label_P1.AutoSize = true;
            this.label_P1.Enabled = false;
            this.label_P1.Location = new System.Drawing.Point(196, 83);
            this.label_P1.Name = "label_P1";
            this.label_P1.Size = new System.Drawing.Size(16, 13);
            this.label_P1.TabIndex = 49;
            this.label_P1.Text = "-1";
            // 
            // label_P2
            // 
            this.label_P2.AutoSize = true;
            this.label_P2.Enabled = false;
            this.label_P2.Location = new System.Drawing.Point(196, 102);
            this.label_P2.Name = "label_P2";
            this.label_P2.Size = new System.Drawing.Size(16, 13);
            this.label_P2.TabIndex = 50;
            this.label_P2.Text = "-1";
            // 
            // label_P3
            // 
            this.label_P3.AutoSize = true;
            this.label_P3.Enabled = false;
            this.label_P3.Location = new System.Drawing.Point(196, 121);
            this.label_P3.Name = "label_P3";
            this.label_P3.Size = new System.Drawing.Size(16, 13);
            this.label_P3.TabIndex = 51;
            this.label_P3.Text = "-1";
            // 
            // noiseLabel
            // 
            this.noiseLabel.AutoSize = true;
            this.noiseLabel.Enabled = false;
            this.noiseLabel.Location = new System.Drawing.Point(95, 159);
            this.noiseLabel.Name = "noiseLabel";
            this.noiseLabel.Size = new System.Drawing.Size(16, 13);
            this.noiseLabel.TabIndex = 52;
            this.noiseLabel.Text = "-1";
            // 
            // groupBox_JoystickState
            // 
            this.groupBox_JoystickState.Controls.Add(this.noiseLabel);
            this.groupBox_JoystickState.Controls.Add(this.label_P3);
            this.groupBox_JoystickState.Controls.Add(this.label_P2);
            this.groupBox_JoystickState.Controls.Add(this.label_P1);
            this.groupBox_JoystickState.Controls.Add(this.label_P0);
            this.groupBox_JoystickState.Controls.Add(this.label_S1);
            this.groupBox_JoystickState.Controls.Add(this.label_S0);
            this.groupBox_JoystickState.Controls.Add(this.label_POV3);
            this.groupBox_JoystickState.Controls.Add(this.label_POV2);
            this.groupBox_JoystickState.Controls.Add(this.label_POV1);
            this.groupBox_JoystickState.Controls.Add(this.label_POV0);
            this.groupBox_JoystickState.Controls.Add(this.label_Slider1);
            this.groupBox_JoystickState.Controls.Add(this.label_Slider0);
            this.groupBox_JoystickState.Controls.Add(this.label_ZRot);
            this.groupBox_JoystickState.Controls.Add(this.label_YRot);
            this.groupBox_JoystickState.Controls.Add(this.label_XRot);
            this.groupBox_JoystickState.Controls.Add(this.label_Z);
            this.groupBox_JoystickState.Controls.Add(this.label_Y);
            this.groupBox_JoystickState.Controls.Add(this.label_X);
            this.groupBox_JoystickState.Controls.Add(this.label_ButtonList);
            this.groupBox_JoystickState.Controls.Add(this.label_Buttons);
            this.groupBox_JoystickState.Controls.Add(this.label_ZRotation);
            this.groupBox_JoystickState.Controls.Add(this.label_YRotation);
            this.groupBox_JoystickState.Controls.Add(this.label_XRotation);
            this.groupBox_JoystickState.Controls.Add(this.label_ZAxis);
            this.groupBox_JoystickState.Controls.Add(this.label_YAxis);
            this.groupBox_JoystickState.Controls.Add(this.label_XAxis);
            this.groupBox_JoystickState.Location = new System.Drawing.Point(1156, 76);
            this.groupBox_JoystickState.Name = "groupBox_JoystickState";
            this.groupBox_JoystickState.Size = new System.Drawing.Size(268, 195);
            this.groupBox_JoystickState.TabIndex = 4;
            this.groupBox_JoystickState.TabStop = false;
            this.groupBox_JoystickState.Text = "Joystick State";
            // 
            // scoreLabelLabel
            // 
            this.scoreLabelLabel.Location = new System.Drawing.Point(189, 553);
            this.scoreLabelLabel.Name = "scoreLabelLabel";
            this.scoreLabelLabel.Size = new System.Drawing.Size(46, 23);
            this.scoreLabelLabel.TabIndex = 36;
            this.scoreLabelLabel.Text = "SCORE:";
            this.scoreLabelLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // blockPanel
            // 
            this.blockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blockPanel.Location = new System.Drawing.Point(0, 0);
            this.blockPanel.Name = "blockPanel";
            this.blockPanel.Size = new System.Drawing.Size(1071, 521);
            this.blockPanel.TabIndex = 3;
            this.blockPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(585, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "LEVEL:";
            // 
            // levelLabel
            // 
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(648, 547);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(49, 23);
            this.levelLabel.TabIndex = 38;
            this.levelLabel.Text = "1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 589);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreLabelLabel);
            this.Controls.Add(this.vibOffButton);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.createDeviceButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label_Message);
            this.Controls.Add(this.groupBox_JoystickState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Unicycle Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unicycle)).EndInit();
            this.groupBox_JoystickState.ResumeLayout(false);
            this.groupBox_JoystickState.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox unicycle;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Button vibOffButton;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Button createDeviceButton;
        private System.Windows.Forms.Label label_XAxis;
        private System.Windows.Forms.Label label_YAxis;
        private System.Windows.Forms.Label label_ZAxis;
        private System.Windows.Forms.Label label_XRotation;
        private System.Windows.Forms.Label label_YRotation;
        private System.Windows.Forms.Label label_ZRotation;
        private System.Windows.Forms.Label label_Buttons;
        private System.Windows.Forms.Label label_ButtonList;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label_Z;
        private System.Windows.Forms.Label label_XRot;
        private System.Windows.Forms.Label label_YRot;
        private System.Windows.Forms.Label label_ZRot;
        private System.Windows.Forms.Label label_Slider0;
        private System.Windows.Forms.Label label_Slider1;
        private System.Windows.Forms.Label label_POV0;
        private System.Windows.Forms.Label label_POV1;
        private System.Windows.Forms.Label label_POV2;
        private System.Windows.Forms.Label label_POV3;
        private System.Windows.Forms.Label label_S0;
        private System.Windows.Forms.Label label_S1;
        private System.Windows.Forms.Label label_P0;
        private System.Windows.Forms.Label label_P1;
        private System.Windows.Forms.Label label_P2;
        private System.Windows.Forms.Label label_P3;
        private System.Windows.Forms.Label noiseLabel;
        private System.Windows.Forms.GroupBox groupBox_JoystickState;
        private System.Windows.Forms.Label scoreLabelLabel;
        private System.Windows.Forms.Label startCounterLabel;
        private System.Windows.Forms.Panel blockPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label levelLabel;
    }
}

