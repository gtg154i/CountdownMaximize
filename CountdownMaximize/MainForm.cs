//https://gtg154i.github.com
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Media;
using System.IO;
using System.Threading;

namespace CountdownMaximize
{
	public partial class MainForm : Form
	{
		//86399 is 23 hrs, 59 mins, 59 seconds. Over this amount breaks Timespan Time Display
		const int MAX_TIME = 86399;
		Size NORMAL_VIEW = new Size(890, 207); //normal view size
		Size COMPACT_VIEW = new Size(550, 44); //compact view size
		
		int timeLeft = 300; //default time left of 5 mins = 300 seconds, current time left
		int timeLeftFull = 300; //use this value as full duration
		String timeLeftFullText = "00:05:00";
		TimeSpan timespan = TimeSpan.FromSeconds(300);
		Icon iconToUse = Resource1._48;
		
		Boolean completed = false; //true if countdown reaches 0
		Boolean reselect = false; //true during user reselecting repeat key
		
		Keys selectedKeycode = Keys.Oemtilde; //default repeat key `
		String selectedKeyText = "`";
		
		public MainForm()
		{
			InitializeComponent();
			this.ClientSize = NORMAL_VIEW;
			
			//we set it as always on top at start until always on top checkbox unclicked
			this.TopMost = true;
		}
		
		private void MainForm_KeyUp(object sender, KeyEventArgs e)
		{
			if (reselect)
			{
				selectedKeycode = e.KeyCode;
				reselect = false;
				KeysConverter converter = new KeysConverter();
				selectedKeyText = converter.ConvertToString(selectedKeycode);
				repeatLabel.Text = "Repeat Key: " + selectedKeyText;
				
				//prevent the Space keypress from activating repeat button during reselect
				if (this.ActiveControl is Button
				    && e.KeyCode == Keys.Space)
				{
					var button = this.ActiveControl;
					button.Enabled = false;
					Application.DoEvents();
					button.Enabled = true;
					button.Focus();
				}
				
				return;
			}
			
			//repeatkey pressed after complete
			if ((e.KeyCode == selectedKeycode) && (completed))
			{
				iconToUse = Resource1._48;
				this.Icon = iconToUse;
				notifyIcon.Icon = iconToUse;
				StartCountdown(); //repeat
			}
		}
		
		private void StartCountdown()
		{
			timespan = TimeSpan.FromSeconds(timeLeft);
			timeLabel.Text = timespan.ToString(@"hh\:mm\:ss");
			this.ClientSize = COMPACT_VIEW;
			this.WindowState = FormWindowState.Normal;
			
			if (minimizeDuringCountCheckbox.Checked)
			{
				this.WindowState = FormWindowState.Minimized;
			}
			completed = false;
			countdownTimeText.Enabled = false;
			timeLeftTimer.Start();
			repeatButton.Enabled = false;
			repeatButton.Visible = false;
		}
		
		private int convertTimeToSeconds(String timeString)
		{
			int convertedTimeLeft = 0;
			
			String[] countdownTimeTextSplit = timeString.Split(':');
			
			int count = timeString.Split(':').Length - 1;
			
			for (int i = 0;i < countdownTimeTextSplit.Length;i++)
			{
				if (countdownTimeTextSplit[i].Equals(""))
					countdownTimeTextSplit[i] = "0";
			}
			
			if (count == 2) //if 2 : assume hrs:mins:seconds
				convertedTimeLeft = Int32.Parse(countdownTimeTextSplit[0])*3600 + Int32.Parse(countdownTimeTextSplit[1])*60 + Int32.Parse(countdownTimeTextSplit[2]);
			
			if (count == 1) //if 1 : assume mins:seconds
				convertedTimeLeft = Int32.Parse(countdownTimeTextSplit[0])*60 + Int32.Parse(countdownTimeTextSplit[1]);
			
			if (count == 0) //if 0 : assume seconds
				convertedTimeLeft = Int32.Parse(countdownTimeText.Text);
			
			//if count > 2 means invalid time e.g. 1:1:1:1, just treats as 0 duration
			
			return convertedTimeLeft;
		}
		
		private void CountdownTimeTextTextChanged(object sender, EventArgs e)
		{
			//prevent blank interval
			if (countdownTimeText.Text.Length == 0)
				timeLeft = 0;
			
			if (countdownTimeText.Text.Length > 0)
			{
				timeLeft = convertTimeToSeconds(countdownTimeText.Text);
				timeLeftFull = timeLeft;
				
				//prevent over 23:59:59 (this breaks display using timespan)
				if (timeLeft > MAX_TIME)
				{
					timeLeft = MAX_TIME;
				}
			}
			
			timespan = TimeSpan.FromSeconds(timeLeft);
			timeLabel.Text = timespan.ToString(@"hh\:mm\:ss");
			timeLeftFullText = timeLabel.Text;
		}
		
		private void CountdownTimeTextKeyPress(object sender, KeyPressEventArgs e)
		{
			
			//only allow numbers and :
			var regex = new Regex(@"[^0-9:\b]");
			if (regex.IsMatch(e.KeyChar.ToString()))
			{
				e.Handled = true;
				return;
			}
		}
		
		private void StartButtonClick(object sender, EventArgs e)
		{
			StartCountdown();
		}
		
		private void ReselectButtonClick(object sender, EventArgs e)
		{
			reselect = true;
			repeatLabel.Text = "Press Key";
		}
		
		private void PauseButtonClick(object sender, EventArgs e)
		{
			timeLeftTimer.Stop();
			if (!timeLabel.Text.Contains(" P"))
			{
				timeLabel.Text += " P";
			}
		}
		
		private void CancelButtonClick(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
			this.Text = "Countdown Maximize";
			this.ClientSize = NORMAL_VIEW;
			completed = false;
			timeLeftTimer.Stop();
			timeLabel.Text = "";
			timeLeft = convertTimeToSeconds(countdownTimeText.Text);
			timeLeftFull = timeLeft;
			countdownTimeText.Enabled = true;
			if (minimizeToTrayCheckbox.Checked)
			{
				iconToUse = Resource1._48;
			}
			this.Icon = Resource1._48;
		}
		
		private void RepeatButtonClick(object sender, EventArgs e)
		{
			iconToUse = Resource1._48;
			this.Icon = iconToUse;
			notifyIcon.Icon = iconToUse;
			StartCountdown(); //repeat
		}
		
		private void TimeLeftTimerTick(object sender, EventArgs e)
		{
			//START OF:countdown still running portion
			if (timeLeft > 0)
			{
				timeLeft = timeLeft - 1;
				timespan = TimeSpan.FromSeconds(timeLeft);
				timeLabel.Text = timespan.ToString(@"hh\:mm\:ss");
				
				if (timeLeftInTitleCheckbox.Checked)
				{
					if (timeLeft > 3600)
						this.Text = timespan.ToString(@"hh\:mm\:ss");
					if (timeLeft >= 60)
						this.Text = timespan.ToString(@"mm\:ss");
					if (timeLeft <= 59)
						this.Text = timespan.ToString(@"ss");
				}
				
				//if (minimizeToTrayCheckbox.Checked)
				if ((animateIconCheckbox.Checked) || (animateTrayIconCheckbox.Checked))
				{
					//start of giant switch case to determine icon
					
					//integer-only formula to get percentage with rounding is:
					//int percent = (timeLeft * 200 + timeLeftFull) / (timeLeftFull * 2);
					//we use half of the percent to determine how many pixels filled in icon
					int percent = (timeLeft * 200 + timeLeftFull) / (timeLeftFull * 4);
					
					//haven't found how to programmatically point the resource icon via a loop
					//so I just did it this way:
					switch (percent)
					{
						case 0:
							iconToUse = Resource1._0;
							break;
						case 1:
							iconToUse = Resource1._1;
							break;
						case 2:
							iconToUse = Resource1._2;
							break;
						case 3:
							iconToUse = Resource1._3;
							break;
						case 4:
							iconToUse = Resource1._4;
							break;
						case 5:
							iconToUse = Resource1._5;
							break;
						case 6:
							iconToUse = Resource1._6;
							break;
						case 7:
							iconToUse = Resource1._7;
							break;
						case 8:
							iconToUse = Resource1._8;
							break;
						case 9:
							iconToUse = Resource1._9;
							break;
						case 10:
							iconToUse = Resource1._10;
							break;
						case 11:
							iconToUse = Resource1._11;
							break;
						case 12:
							iconToUse = Resource1._12;
							break;
						case 13:
							iconToUse = Resource1._13;
							break;
						case 14:
							iconToUse = Resource1._14;
							break;
						case 15:
							iconToUse = Resource1._15;
							break;
						case 16:
							iconToUse = Resource1._16;
							break;
						case 17:
							iconToUse = Resource1._17;
							break;
						case 18:
							iconToUse = Resource1._18;
							break;
						case 19:
							iconToUse = Resource1._19;
							break;
						case 20:
							iconToUse = Resource1._20;
							break;
						case 21:
							iconToUse = Resource1._21;
							break;
						case 22:
							iconToUse = Resource1._22;
							break;
						case 23:
							iconToUse = Resource1._23;
							break;
						case 24:
							iconToUse = Resource1._24;
							break;
						case 25:
							iconToUse = Resource1._25;
							break;
						case 26:
							iconToUse = Resource1._26;
							break;
						case 27:
							iconToUse = Resource1._27;
							break;
						case 28:
							iconToUse = Resource1._28;
							break;
						case 29:
							iconToUse = Resource1._29;
							break;
						case 30:
							iconToUse = Resource1._30;
							break;
						case 31:
							iconToUse = Resource1._31;
							break;
						case 32:
							iconToUse = Resource1._32;
							break;
						case 33:
							iconToUse = Resource1._33;
							break;
						case 34:
							iconToUse = Resource1._34;
							break;
						case 35:
							iconToUse = Resource1._35;
							break;
						case 36:
							iconToUse = Resource1._36;
							break;
						case 37:
							iconToUse = Resource1._37;
							break;
						case 38:
							iconToUse = Resource1._38;
							break;
						case 39:
							iconToUse = Resource1._39;
							break;
						case 40:
							iconToUse = Resource1._40;
							break;
						case 41:
							iconToUse = Resource1._41;
							break;
						case 42:
							iconToUse = Resource1._42;
							break;
						case 43:
							iconToUse = Resource1._43;
							break;
						case 44:
							iconToUse = Resource1._44;
							break;
						case 45:
							iconToUse = Resource1._45;
							break;
						case 46:
							iconToUse = Resource1._46;
							break;
						case 47:
							iconToUse = Resource1._47;
							break;
						case 48:
							iconToUse = Resource1._48;
							break;
						case 49: //it's a 48x48 icon so we use the same icon for 95-100%
							iconToUse = Resource1._48;
							break;
						case 50: //it's a 48x48 icon so we use the same icon for 95-100%
							iconToUse = Resource1._48;
							break;
					}
					//end of giant switch case to determine icon
					
					if (animateIconCheckbox.Checked)
					{
						this.Icon = iconToUse;
					}
					
					if (animateTrayIconCheckbox.Checked)
					{
						notifyIcon.Icon = iconToUse;
					}
					
				}
				
			}
			
			//END OF:countdown still running portion
			
			//START OF:countdown ended portion
			else
			{
				timeLeftTimer.Stop();
				timeLabel.Text = "";
				//repeatButton.Text = "Countdown Ended. Click to repeat or press " + selectedKeyText;
				repeatButton.Text = timeLeftFullText + " Ended. Click to repeat or press " + selectedKeyText;
				
				this.ClientSize = NORMAL_VIEW;
				if (maxAtZeroCheckbox.Checked)
				{
					this.WindowState = FormWindowState.Maximized;
				}
				timeLeft = convertTimeToSeconds(countdownTimeText.Text);
				countdownTimeText.Enabled = true;
				
				repeatButton.Enabled = true;
				repeatButton.Visible = true;
				
				completed = true;
				Screen myScreen = Screen.PrimaryScreen;
				int mywidth = (myScreen.WorkingArea.Width);
				int myheight = (myScreen.WorkingArea.Height);
				repeatButton.Width = mywidth;
				repeatButton.Height = myheight;
				
				if (stealFocusCheckbox.Checked)
				{
					//Steal focus.
					this.Show();
					this.Activate();
				}
				
				if (soundCheckbox.Checked)
				{
					Application.DoEvents();
					
					using (var firePagerAudioStream = new MemoryStream(Resource1.Fire_pager))
					{
						using (var player = new SoundPlayer(firePagerAudioStream))
						{
							player.Play();
						}
					}
				}
				
				if (autoRepeatCheckbox.Checked)
				{
					System.Threading.Thread.Sleep(10000);
					iconToUse = Resource1._48;
					this.Icon = iconToUse;
					notifyIcon.Icon = iconToUse;
					StartCountdown(); //repeat
				}
				
			}
			//END OF:countdown ended portion
		}
		
		private void AlwaysOnTopCheckboxCheckedChanged(object sender, EventArgs e)
		{
			this.TopMost = alwaysOnTopCheckbox.Checked;
		}
		
		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{

				if (minimizeToTrayCheckbox.Checked)
				{
					Hide();
					notifyIcon.Visible = true;
				}
			}
		}
		
		private void notifyIcon_Click(object sender, EventArgs e)
		{
			Show();
			this.WindowState = FormWindowState.Normal;
			notifyIcon.Visible = false;
		}
	}
	
}
