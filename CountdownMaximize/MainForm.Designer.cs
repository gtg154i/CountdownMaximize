//https://gtg154i.github.com
using System;
namespace CountdownMaximize
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.countdownTimeText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.maxAtZeroCheckbox = new System.Windows.Forms.CheckBox();
			this.alwaysOnTopCheckbox = new System.Windows.Forms.CheckBox();
			this.stealFocusCheckbox = new System.Windows.Forms.CheckBox();
			this.soundCheckbox = new System.Windows.Forms.CheckBox();
			this.startButton = new System.Windows.Forms.Button();
			this.timeLeftTimer = new System.Windows.Forms.Timer(this.components);
			this.timeLabel = new System.Windows.Forms.Label();
			this.pauseButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.repeatButton = new System.Windows.Forms.Button();
			this.minimizeDuringCountCheckbox = new System.Windows.Forms.CheckBox();
			this.minimizeToTrayCheckbox = new System.Windows.Forms.CheckBox();
			this.repeatLabel = new System.Windows.Forms.Label();
			this.reselectButton = new System.Windows.Forms.Button();
			this.timeLeftInTitleCheckbox = new System.Windows.Forms.CheckBox();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.animateIconCheckbox = new System.Windows.Forms.CheckBox();
			this.animateTrayIconCheckbox = new System.Windows.Forms.CheckBox();
			this.autoRepeatCheckbox = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// countdownTimeText
			// 
			this.countdownTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.countdownTimeText.Location = new System.Drawing.Point(146, 48);
			this.countdownTimeText.Name = "countdownTimeText";
			this.countdownTimeText.Size = new System.Drawing.Size(166, 39);
			this.countdownTimeText.TabIndex = 2;
			this.countdownTimeText.Text = "00:05:00";
			this.countdownTimeText.TextChanged += new System.EventHandler(this.CountdownTimeTextTextChanged);
			this.countdownTimeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountdownTimeTextKeyPress);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 32);
			this.label1.TabIndex = 5;
			this.label1.Text = "Duration:";
			// 
			// maxAtZeroCheckbox
			// 
			this.maxAtZeroCheckbox.Checked = true;
			this.maxAtZeroCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.maxAtZeroCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maxAtZeroCheckbox.Location = new System.Drawing.Point(556, 10);
			this.maxAtZeroCheckbox.Name = "maxAtZeroCheckbox";
			this.maxAtZeroCheckbox.Size = new System.Drawing.Size(310, 32);
			this.maxAtZeroCheckbox.TabIndex = 7;
			this.maxAtZeroCheckbox.Text = "Maximize When Zero";
			this.maxAtZeroCheckbox.UseVisualStyleBackColor = true;
			// 
			// alwaysOnTopCheckbox
			// 
			this.alwaysOnTopCheckbox.Checked = true;
			this.alwaysOnTopCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.alwaysOnTopCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.alwaysOnTopCheckbox.Location = new System.Drawing.Point(656, 47);
			this.alwaysOnTopCheckbox.Name = "alwaysOnTopCheckbox";
			this.alwaysOnTopCheckbox.Size = new System.Drawing.Size(235, 40);
			this.alwaysOnTopCheckbox.TabIndex = 8;
			this.alwaysOnTopCheckbox.Text = "Always On Top";
			this.alwaysOnTopCheckbox.UseVisualStyleBackColor = true;
			this.alwaysOnTopCheckbox.CheckedChanged += new System.EventHandler(this.AlwaysOnTopCheckboxCheckedChanged);
			// 
			// stealFocusCheckbox
			// 
			this.stealFocusCheckbox.Checked = true;
			this.stealFocusCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.stealFocusCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.stealFocusCheckbox.Location = new System.Drawing.Point(318, 44);
			this.stealFocusCheckbox.Name = "stealFocusCheckbox";
			this.stealFocusCheckbox.Size = new System.Drawing.Size(190, 40);
			this.stealFocusCheckbox.TabIndex = 9;
			this.stealFocusCheckbox.Text = "Steal Focus";
			this.stealFocusCheckbox.UseVisualStyleBackColor = true;
			// 
			// soundCheckbox
			// 
			this.soundCheckbox.Checked = true;
			this.soundCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.soundCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.soundCheckbox.Location = new System.Drawing.Point(520, 47);
			this.soundCheckbox.Name = "soundCheckbox";
			this.soundCheckbox.Size = new System.Drawing.Size(130, 40);
			this.soundCheckbox.TabIndex = 11;
			this.soundCheckbox.Text = "Sound";
			this.soundCheckbox.UseVisualStyleBackColor = true;
			// 
			// startButton
			// 
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.Location = new System.Drawing.Point(213, 5);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(105, 40);
			this.startButton.TabIndex = 10;
			this.startButton.TabStop = false;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.StartButtonClick);
			// 
			// timeLeftTimer
			// 
			this.timeLeftTimer.Interval = 1000;
			this.timeLeftTimer.Tick += new System.EventHandler(this.TimeLeftTimerTick);
			// 
			// timeLabel
			// 
			this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeLabel.ForeColor = System.Drawing.Color.Blue;
			this.timeLabel.Location = new System.Drawing.Point(12, 9);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(195, 40);
			this.timeLabel.TabIndex = 12;
			this.timeLabel.Text = "05:00";
			// 
			// pauseButton
			// 
			this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pauseButton.Location = new System.Drawing.Point(324, 5);
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Size = new System.Drawing.Size(105, 40);
			this.pauseButton.TabIndex = 13;
			this.pauseButton.TabStop = false;
			this.pauseButton.Text = "Pause";
			this.pauseButton.UseVisualStyleBackColor = true;
			this.pauseButton.Click += new System.EventHandler(this.PauseButtonClick);
			// 
			// cancelButton
			// 
			this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(435, 5);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(115, 40);
			this.cancelButton.TabIndex = 14;
			this.cancelButton.TabStop = false;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// repeatButton
			// 
			this.repeatButton.Enabled = false;
			this.repeatButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.repeatButton.Location = new System.Drawing.Point(12, 213);
			this.repeatButton.Name = "repeatButton";
			this.repeatButton.Size = new System.Drawing.Size(870, 640);
			this.repeatButton.TabIndex = 15;
			this.repeatButton.Text = "Countdown Ended. Click to repeat or press `";
			this.repeatButton.UseVisualStyleBackColor = true;
			this.repeatButton.Visible = false;
			this.repeatButton.Click += new System.EventHandler(this.RepeatButtonClick);
			// 
			// minimizeDuringCountCheckbox
			// 
			this.minimizeDuringCountCheckbox.Checked = true;
			this.minimizeDuringCountCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.minimizeDuringCountCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minimizeDuringCountCheckbox.Location = new System.Drawing.Point(12, 87);
			this.minimizeDuringCountCheckbox.Name = "minimizeDuringCountCheckbox";
			this.minimizeDuringCountCheckbox.Size = new System.Drawing.Size(330, 40);
			this.minimizeDuringCountCheckbox.TabIndex = 16;
			this.minimizeDuringCountCheckbox.Text = "Minimize During Count";
			this.minimizeDuringCountCheckbox.UseVisualStyleBackColor = true;
			// 
			// minimizeToTrayCheckbox
			// 
			this.minimizeToTrayCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minimizeToTrayCheckbox.Location = new System.Drawing.Point(613, 87);
			this.minimizeToTrayCheckbox.Name = "minimizeToTrayCheckbox";
			this.minimizeToTrayCheckbox.Size = new System.Drawing.Size(261, 40);
			this.minimizeToTrayCheckbox.TabIndex = 18;
			this.minimizeToTrayCheckbox.Text = "Minimize To Tray";
			this.minimizeToTrayCheckbox.UseVisualStyleBackColor = true;
			// 
			// repeatLabel
			// 
			this.repeatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.repeatLabel.Location = new System.Drawing.Point(12, 167);
			this.repeatLabel.Name = "repeatLabel";
			this.repeatLabel.Size = new System.Drawing.Size(430, 32);
			this.repeatLabel.TabIndex = 19;
			this.repeatLabel.Text = "Repeat Key: `";
			// 
			// reselectButton
			// 
			this.reselectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reselectButton.Location = new System.Drawing.Point(448, 167);
			this.reselectButton.Name = "reselectButton";
			this.reselectButton.Size = new System.Drawing.Size(135, 40);
			this.reselectButton.TabIndex = 20;
			this.reselectButton.TabStop = false;
			this.reselectButton.Text = "Reselect";
			this.reselectButton.UseVisualStyleBackColor = true;
			this.reselectButton.Click += new System.EventHandler(this.ReselectButtonClick);
			// 
			// timeLeftInTitleCheckbox
			// 
			this.timeLeftInTitleCheckbox.Checked = true;
			this.timeLeftInTitleCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.timeLeftInTitleCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeLeftInTitleCheckbox.Location = new System.Drawing.Point(348, 87);
			this.timeLeftInTitleCheckbox.Name = "timeLeftInTitleCheckbox";
			this.timeLeftInTitleCheckbox.Size = new System.Drawing.Size(250, 40);
			this.timeLeftInTitleCheckbox.TabIndex = 21;
			this.timeLeftInTitleCheckbox.Text = "Time Left In Title";
			this.timeLeftInTitleCheckbox.UseVisualStyleBackColor = true;
			// 
			// notifyIcon
			// 
			this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon.BalloonTipText = "Countdown Maximize";
			this.notifyIcon.BalloonTipTitle = "Countdown Maximize";
			this.notifyIcon.Icon = global::CountdownMaximize.Resource1._48;
			this.notifyIcon.Text = "Countdown Maximize";
			this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
			// 
			// animateIconCheckbox
			// 
			this.animateIconCheckbox.Checked = true;
			this.animateIconCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.animateIconCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.animateIconCheckbox.Location = new System.Drawing.Point(12, 127);
			this.animateIconCheckbox.Name = "animateIconCheckbox";
			this.animateIconCheckbox.Size = new System.Drawing.Size(210, 40);
			this.animateIconCheckbox.TabIndex = 22;
			this.animateIconCheckbox.Text = "Animate Icon";
			this.animateIconCheckbox.UseVisualStyleBackColor = true;
			// 
			// animateTrayIconCheckbox
			// 
			this.animateTrayIconCheckbox.Checked = true;
			this.animateTrayIconCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.animateTrayIconCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.animateTrayIconCheckbox.Location = new System.Drawing.Point(228, 127);
			this.animateTrayIconCheckbox.Name = "animateTrayIconCheckbox";
			this.animateTrayIconCheckbox.Size = new System.Drawing.Size(270, 40);
			this.animateTrayIconCheckbox.TabIndex = 23;
			this.animateTrayIconCheckbox.Text = "Animate Tray Icon";
			this.animateTrayIconCheckbox.UseVisualStyleBackColor = true;
			// 
			// autoRepeatCheckbox
			// 
			this.autoRepeatCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.autoRepeatCheckbox.Location = new System.Drawing.Point(490, 127);
			this.autoRepeatCheckbox.Name = "autoRepeatCheckbox";
			this.autoRepeatCheckbox.Size = new System.Drawing.Size(320, 40);
			this.autoRepeatCheckbox.TabIndex = 24;
			this.autoRepeatCheckbox.Text = "Auto Repeat After 10s";
			this.autoRepeatCheckbox.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(890, 862);
			this.Controls.Add(this.autoRepeatCheckbox);
			this.Controls.Add(this.animateTrayIconCheckbox);
			this.Controls.Add(this.animateIconCheckbox);
			this.Controls.Add(this.timeLeftInTitleCheckbox);
			this.Controls.Add(this.reselectButton);
			this.Controls.Add(this.repeatLabel);
			this.Controls.Add(this.minimizeToTrayCheckbox);
			this.Controls.Add(this.minimizeDuringCountCheckbox);
			this.Controls.Add(this.repeatButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.pauseButton);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.soundCheckbox);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.stealFocusCheckbox);
			this.Controls.Add(this.alwaysOnTopCheckbox);
			this.Controls.Add(this.maxAtZeroCheckbox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.countdownTimeText);
			this.Icon = global::CountdownMaximize.Resource1._48;
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.Text = "Countdown Maximize";
			this.Click += new System.EventHandler(this.notifyIcon_Click);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.CheckBox stealFocusCheckbox;
		private System.Windows.Forms.CheckBox maxAtZeroCheckbox;
		private System.Windows.Forms.CheckBox alwaysOnTopCheckbox;
		private System.Windows.Forms.CheckBox soundCheckbox;
		private System.Windows.Forms.CheckBox animateIconCheckbox;
		private System.Windows.Forms.CheckBox animateTrayIconCheckbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox countdownTimeText;
		private System.Windows.Forms.Timer timeLeftTimer;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.Button pauseButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button repeatButton;
		private System.Windows.Forms.CheckBox minimizeDuringCountCheckbox;
		private System.Windows.Forms.CheckBox minimizeToTrayCheckbox;
		private System.Windows.Forms.Label repeatLabel;
		private System.Windows.Forms.Button reselectButton;
		private System.Windows.Forms.CheckBox timeLeftInTitleCheckbox;
		private System.Windows.Forms.CheckBox autoRepeatCheckbox;
	}
}