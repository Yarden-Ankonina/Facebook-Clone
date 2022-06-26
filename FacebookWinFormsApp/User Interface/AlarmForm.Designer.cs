namespace BasicFacebookFeatures.User_Interface
{
    public partial class AlarmForm
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
            this.labelUsingTime = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAlarmReminder = new System.Windows.Forms.Label();
            this.comboBoxSelectAlarm = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemAlarm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStopWatch = new System.Windows.Forms.ToolStripMenuItem();
            this.panelAlarmContent = new System.Windows.Forms.Panel();
            this.labelStopWatchTime = new System.Windows.Forms.Label();
            this.buttonStartStopWatch = new System.Windows.Forms.Button();
            this.buttonResetStopWatch = new System.Windows.Forms.Button();
            this.panelContentStopWatch = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panelAlarmContent.SuspendLayout();
            this.panelContentStopWatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsingTime
            // 
            this.labelUsingTime.AutoSize = true;
            this.labelUsingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsingTime.Location = new System.Drawing.Point(191, 60);
            this.labelUsingTime.Name = "labelUsingTime";
            this.labelUsingTime.Size = new System.Drawing.Size(278, 58);
            this.labelUsingTime.TabIndex = 0;
            this.labelUsingTime.Text = "Using Time";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelTitle.Location = new System.Drawing.Point(131, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(413, 29);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Amount Of Time Your On The App :";
            // 
            // labelAlarmReminder
            // 
            this.labelAlarmReminder.AutoSize = true;
            this.labelAlarmReminder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelAlarmReminder.Location = new System.Drawing.Point(52, 196);
            this.labelAlarmReminder.Name = "labelAlarmReminder";
            this.labelAlarmReminder.Size = new System.Drawing.Size(356, 29);
            this.labelAlarmReminder.TabIndex = 2;
            this.labelAlarmReminder.Text = "Alarm Break Reminder Every :";
            // 
            // comboBoxSelectAlarm
            // 
            this.comboBoxSelectAlarm.FormattingEnabled = true;
            this.comboBoxSelectAlarm.Location = new System.Drawing.Point(436, 202);
            this.comboBoxSelectAlarm.Name = "comboBoxSelectAlarm";
            this.comboBoxSelectAlarm.Size = new System.Drawing.Size(187, 24);
            this.comboBoxSelectAlarm.TabIndex = 3;
            this.comboBoxSelectAlarm.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectAlarm_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAlarm,
            this.toolStripMenuItemStopWatch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 38);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemAlarm
            // 
            this.toolStripMenuItemAlarm.Name = "toolStripMenuItemAlarm";
            this.toolStripMenuItemAlarm.Size = new System.Drawing.Size(63, 24);
            this.toolStripMenuItemAlarm.Text = "&Alarm";
            this.toolStripMenuItemAlarm.Click += new System.EventHandler(this.toolStripMenuItemAlarm_Click);
            // 
            // toolStripMenuItemStopWatch
            // 
            this.toolStripMenuItemStopWatch.Name = "toolStripMenuItemStopWatch";
            this.toolStripMenuItemStopWatch.Size = new System.Drawing.Size(95, 24);
            this.toolStripMenuItemStopWatch.Text = "&StopWatch";
            this.toolStripMenuItemStopWatch.Click += new System.EventHandler(this.toolStripMenuItemStopWatch_Click);
            // 
            // panelAlarmContent
            // 
            this.panelAlarmContent.Controls.Add(this.comboBoxSelectAlarm);
            this.panelAlarmContent.Controls.Add(this.labelAlarmReminder);
            this.panelAlarmContent.Controls.Add(this.labelTitle);
            this.panelAlarmContent.Controls.Add(this.labelUsingTime);
            this.panelAlarmContent.Location = new System.Drawing.Point(58, 56);
            this.panelAlarmContent.Name = "panelAlarmContent";
            this.panelAlarmContent.Size = new System.Drawing.Size(670, 281);
            this.panelAlarmContent.TabIndex = 5;
            // 
            // labelStopWatchTime
            // 
            this.labelStopWatchTime.AutoSize = true;
            this.labelStopWatchTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStopWatchTime.Location = new System.Drawing.Point(174, 80);
            this.labelStopWatchTime.Name = "labelStopWatchTime";
            this.labelStopWatchTime.Size = new System.Drawing.Size(312, 58);
            this.labelStopWatchTime.TabIndex = 0;
            this.labelStopWatchTime.Text = "0 0 : 0 0 : 0 0";
            // 
            // buttonStartStopWatch
            // 
            this.buttonStartStopWatch.Location = new System.Drawing.Point(201, 202);
            this.buttonStartStopWatch.Name = "buttonStartStopWatch";
            this.buttonStartStopWatch.Size = new System.Drawing.Size(112, 42);
            this.buttonStartStopWatch.TabIndex = 7;
            this.buttonStartStopWatch.Text = "Start";
            this.buttonStartStopWatch.UseVisualStyleBackColor = true;
            this.buttonStartStopWatch.Click += new System.EventHandler(this.buttonStartStopWatch_Click);
            // 
            // buttonResetStopWatch
            // 
            this.buttonResetStopWatch.Location = new System.Drawing.Point(337, 202);
            this.buttonResetStopWatch.Name = "buttonResetStopWatch";
            this.buttonResetStopWatch.Size = new System.Drawing.Size(112, 42);
            this.buttonResetStopWatch.TabIndex = 8;
            this.buttonResetStopWatch.Text = "Reset";
            this.buttonResetStopWatch.UseVisualStyleBackColor = true;
            this.buttonResetStopWatch.Click += new System.EventHandler(this.buttonResetStopWatch_Click);
            // 
            // panelContentStopWatch
            // 
            this.panelContentStopWatch.Controls.Add(this.buttonResetStopWatch);
            this.panelContentStopWatch.Controls.Add(this.buttonStartStopWatch);
            this.panelContentStopWatch.Controls.Add(this.labelStopWatchTime);
            this.panelContentStopWatch.Location = new System.Drawing.Point(58, 56);
            this.panelContentStopWatch.Name = "panelContentStopWatch";
            this.panelContentStopWatch.Size = new System.Drawing.Size(667, 281);
            this.panelContentStopWatch.TabIndex = 9;
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelAlarmContent);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelContentStopWatch);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlarmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelAlarmContent.ResumeLayout(false);
            this.panelAlarmContent.PerformLayout();
            this.panelContentStopWatch.ResumeLayout(false);
            this.panelContentStopWatch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsingTime;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAlarmReminder;
        private System.Windows.Forms.ComboBox comboBoxSelectAlarm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAlarm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStopWatch;
        private System.Windows.Forms.Panel panelAlarmContent;
        private System.Windows.Forms.Label labelStopWatchTime;
        private System.Windows.Forms.Button buttonStartStopWatch;
        private System.Windows.Forms.Button buttonResetStopWatch;
        private System.Windows.Forms.Panel panelContentStopWatch;
    }
}