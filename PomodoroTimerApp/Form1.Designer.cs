
namespace PomodoroTimerApp
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeOutputLabel = new System.Windows.Forms.Label();
            this.pomodoroButton = new System.Windows.Forms.Button();
            this.shortBreakButton = new System.Windows.Forms.Button();
            this.longBreakButton = new System.Windows.Forms.Button();
            this.startStopButton = new System.Windows.Forms.Button();
            this.PTimer = new System.Windows.Forms.Timer(this.components);
            this.STimer = new System.Windows.Forms.Timer(this.components);
            this.LTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(756, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // timeOutputLabel
            // 
            this.timeOutputLabel.AutoSize = true;
            this.timeOutputLabel.Font = new System.Drawing.Font("Microsoft Yi Baiti", 99F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeOutputLabel.Location = new System.Drawing.Point(143, 153);
            this.timeOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeOutputLabel.Name = "timeOutputLabel";
            this.timeOutputLabel.Size = new System.Drawing.Size(143, 165);
            this.timeOutputLabel.TabIndex = 1;
            this.timeOutputLabel.Text = " ";
            // 
            // pomodoroButton
            // 
            this.pomodoroButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pomodoroButton.Location = new System.Drawing.Point(11, 83);
            this.pomodoroButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pomodoroButton.Name = "pomodoroButton";
            this.pomodoroButton.Size = new System.Drawing.Size(234, 48);
            this.pomodoroButton.TabIndex = 2;
            this.pomodoroButton.Text = "Pomodoro";
            this.pomodoroButton.UseVisualStyleBackColor = true;
            this.pomodoroButton.Click += new System.EventHandler(this.PomodoroButton_Click);
            // 
            // shortBreakButton
            // 
            this.shortBreakButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortBreakButton.Location = new System.Drawing.Point(253, 83);
            this.shortBreakButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.shortBreakButton.Name = "shortBreakButton";
            this.shortBreakButton.Size = new System.Drawing.Size(244, 48);
            this.shortBreakButton.TabIndex = 3;
            this.shortBreakButton.Text = "Short Break";
            this.shortBreakButton.UseVisualStyleBackColor = true;
            this.shortBreakButton.Click += new System.EventHandler(this.shortBreakButton_Click);
            // 
            // longBreakButton
            // 
            this.longBreakButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longBreakButton.Location = new System.Drawing.Point(505, 83);
            this.longBreakButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.longBreakButton.Name = "longBreakButton";
            this.longBreakButton.Size = new System.Drawing.Size(234, 48);
            this.longBreakButton.TabIndex = 4;
            this.longBreakButton.Text = "Long Break";
            this.longBreakButton.UseVisualStyleBackColor = true;
            this.longBreakButton.Click += new System.EventHandler(this.longBreakButton_Click);
            // 
            // startStopButton
            // 
            this.startStopButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 45F);
            this.startStopButton.Location = new System.Drawing.Point(11, 341);
            this.startStopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(728, 169);
            this.startStopButton.TabIndex = 5;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // PTimer
            // 
            this.PTimer.Interval = 1000;
            this.PTimer.Tick += new System.EventHandler(this.PTimer_Tick);
            // 
            // STimer
            // 
            this.STimer.Interval = 1000;
            this.STimer.Tick += new System.EventHandler(this.STimer_Tick);
            // 
            // LTimer
            // 
            this.LTimer.Interval = 1000;
            this.LTimer.Tick += new System.EventHandler(this.LTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 525);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.longBreakButton);
            this.Controls.Add(this.shortBreakButton);
            this.Controls.Add(this.pomodoroButton);
            this.Controls.Add(this.timeOutputLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Pomodoro Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label timeOutputLabel;
        private System.Windows.Forms.Button pomodoroButton;
        private System.Windows.Forms.Button shortBreakButton;
        private System.Windows.Forms.Button longBreakButton;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Timer PTimer;
        private System.Windows.Forms.Timer STimer;
        private System.Windows.Forms.Timer LTimer;
    }
}

