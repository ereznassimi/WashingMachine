namespace WashingMachine.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelLeft = new Panel();
            labelStopWatch = new Label();
            buttonStart = new Button();
            buttonLock = new Button();
            groupBoxPrograms = new GroupBox();
            radioButtonTest = new RadioButton();
            radioButtonRinse = new RadioButton();
            radioButtonHeavy = new RadioButton();
            radioButtonQuick = new RadioButton();
            radioButtonDelicate = new RadioButton();
            radioButtonNormal = new RadioButton();
            buttonOnOff = new Button();
            panelRight = new Panel();
            textBoxMessages = new TextBox();
            timerStopWatch = new System.Windows.Forms.Timer(components);
            panelLeft.SuspendLayout();
            groupBoxPrograms.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(labelStopWatch);
            panelLeft.Controls.Add(buttonStart);
            panelLeft.Controls.Add(buttonLock);
            panelLeft.Controls.Add(groupBoxPrograms);
            panelLeft.Controls.Add(buttonOnOff);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(400, 450);
            panelLeft.TabIndex = 0;
            // 
            // labelStopWatch
            // 
            labelStopWatch.AutoSize = true;
            labelStopWatch.BackColor = Color.Black;
            labelStopWatch.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStopWatch.ForeColor = Color.Lime;
            labelStopWatch.Location = new Point(205, 358);
            labelStopWatch.Name = "labelStopWatch";
            labelStopWatch.Size = new Size(191, 86);
            labelStopWatch.TabIndex = 13;
            labelStopWatch.Text = "00:00";
            // 
            // buttonStart
            // 
            buttonStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.Image = (Image)resources.GetObject("buttonStart.Image");
            buttonStart.ImageAlign = ContentAlignment.MiddleLeft;
            buttonStart.Location = new Point(200, 289);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(200, 69);
            buttonStart.TabIndex = 12;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonLock
            // 
            buttonLock.Dock = DockStyle.Top;
            buttonLock.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLock.Image = Properties.Resources.lock_open_icon;
            buttonLock.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLock.Location = new Point(200, 92);
            buttonLock.Name = "buttonLock";
            buttonLock.Size = new Size(200, 69);
            buttonLock.TabIndex = 2;
            buttonLock.Text = "Lock";
            buttonLock.UseVisualStyleBackColor = true;
            buttonLock.Click += buttonLock_Click;
            // 
            // groupBoxPrograms
            // 
            groupBoxPrograms.Controls.Add(radioButtonTest);
            groupBoxPrograms.Controls.Add(radioButtonRinse);
            groupBoxPrograms.Controls.Add(radioButtonHeavy);
            groupBoxPrograms.Controls.Add(radioButtonQuick);
            groupBoxPrograms.Controls.Add(radioButtonDelicate);
            groupBoxPrograms.Controls.Add(radioButtonNormal);
            groupBoxPrograms.Dock = DockStyle.Left;
            groupBoxPrograms.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxPrograms.Location = new Point(0, 92);
            groupBoxPrograms.Name = "groupBoxPrograms";
            groupBoxPrograms.Size = new Size(200, 358);
            groupBoxPrograms.TabIndex = 6;
            groupBoxPrograms.TabStop = false;
            groupBoxPrograms.Text = "Select a Program";
            // 
            // radioButtonNormal
            // 
            radioButtonNormal.AutoSize = true;
            radioButtonNormal.Checked = true;
            radioButtonNormal.Dock = DockStyle.Top;
            radioButtonNormal.Location = new Point(3, 25);
            radioButtonNormal.Name = "radioButtonNormal";
            radioButtonNormal.Size = new Size(194, 25);
            radioButtonNormal.TabIndex = 0;
            radioButtonNormal.TabStop = true;
            radioButtonNormal.Text = "Normal";
            radioButtonNormal.UseVisualStyleBackColor = true;
            // 
            // radioButtonDelicate
            // 
            radioButtonDelicate.AutoSize = true;
            radioButtonDelicate.Dock = DockStyle.Top;
            radioButtonDelicate.Location = new Point(3, 50);
            radioButtonDelicate.Name = "radioButtonDelicate";
            radioButtonDelicate.Size = new Size(194, 25);
            radioButtonDelicate.TabIndex = 1;
            radioButtonDelicate.Text = "Delicate Wash";
            radioButtonDelicate.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuick
            // 
            radioButtonQuick.AutoSize = true;
            radioButtonQuick.Dock = DockStyle.Top;
            radioButtonQuick.Location = new Point(3, 75);
            radioButtonQuick.Name = "radioButtonQuick";
            radioButtonQuick.Size = new Size(194, 25);
            radioButtonQuick.TabIndex = 2;
            radioButtonQuick.Text = "Quick Wash";
            radioButtonQuick.UseVisualStyleBackColor = true;
            // 
            // radioButtonHeavy
            // 
            radioButtonHeavy.AutoSize = true;
            radioButtonHeavy.Dock = DockStyle.Top;
            radioButtonHeavy.Location = new Point(3, 100);
            radioButtonHeavy.Name = "radioButtonHeavy";
            radioButtonHeavy.Size = new Size(194, 25);
            radioButtonHeavy.TabIndex = 3;
            radioButtonHeavy.Text = "Heavy Wash";
            radioButtonHeavy.UseVisualStyleBackColor = true;
            // 
            // radioButtonRinse
            // 
            radioButtonRinse.AutoSize = true;
            radioButtonRinse.Dock = DockStyle.Top;
            radioButtonRinse.Location = new Point(3, 125);
            radioButtonRinse.Name = "radioButtonRinse";
            radioButtonRinse.Size = new Size(194, 25);
            radioButtonRinse.TabIndex = 4;
            radioButtonRinse.Text = "Rinse && Spin";
            radioButtonRinse.UseVisualStyleBackColor = true;
            // 
            // radioButtonTest
            // 
            radioButtonTest.AutoSize = true;
            radioButtonTest.Dock = DockStyle.Bottom;
            radioButtonTest.Location = new Point(3, 330);
            radioButtonTest.Name = "radioButtonTest";
            radioButtonTest.Size = new Size(194, 25);
            radioButtonTest.TabIndex = 5;
            radioButtonTest.Text = "Test";
            radioButtonTest.UseVisualStyleBackColor = true;
            // 
            // buttonOnOff
            // 
            buttonOnOff.Dock = DockStyle.Top;
            buttonOnOff.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonOnOff.Image = Properties.Resources.switch_off_on_icon;
            buttonOnOff.ImageAlign = ContentAlignment.MiddleLeft;
            buttonOnOff.Location = new Point(0, 0);
            buttonOnOff.Name = "buttonOnOff";
            buttonOnOff.Size = new Size(400, 92);
            buttonOnOff.TabIndex = 10;
            buttonOnOff.Text = "Turn On";
            buttonOnOff.UseVisualStyleBackColor = true;
            buttonOnOff.Click += buttonOnOff_Click;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(textBoxMessages);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(400, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(400, 450);
            panelRight.TabIndex = 20;
            // 
            // textBoxMessages
            // 
            textBoxMessages.BackColor = Color.Black;
            textBoxMessages.Dock = DockStyle.Fill;
            textBoxMessages.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMessages.ForeColor = Color.White;
            textBoxMessages.Location = new Point(0, 0);
            textBoxMessages.Multiline = true;
            textBoxMessages.Name = "textBoxMessages";
            textBoxMessages.ReadOnly = true;
            textBoxMessages.ScrollBars = ScrollBars.Both;
            textBoxMessages.Size = new Size(400, 450);
            textBoxMessages.TabIndex = 21;
            // 
            // timerStopWatch
            // 
            timerStopWatch.Interval = 1000;
            timerStopWatch.Tick += timerStopWatch_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Washing Machine";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            groupBoxPrograms.ResumeLayout(false);
            groupBoxPrograms.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Button buttonOnOff;
        private Panel panelRight;
        private TextBox textBoxMessages;
        private GroupBox groupBoxPrograms;
        private RadioButton radioButtonNormal;
        private RadioButton radioButtonDelicate;
        private RadioButton radioButtonQuick;
        private RadioButton radioButtonHeavy;
        private RadioButton radioButtonRinse;
        private RadioButton radioButtonTest;
        private Button buttonStart;
        private Button buttonLock;
        private Label labelStopWatch;
        private System.Windows.Forms.Timer timerStopWatch;
    }
}
