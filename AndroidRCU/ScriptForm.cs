/*
 * 由SharpDevelop创建。
 * 用户： jason_su
 * 日期: 09/13/2023
 * 时间: AM 10:24
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;


namespace AndroidRCU
{
	/// <summary>
	/// Description of ScriptForm.
	/// </summary>
	public partial class ScriptForm : Form
	{
		int loopStartLine = 0;
		
		public ScriptForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ScriptFormLoad(object sender, EventArgs e)
		{
			SetButtonToCanStart();
			timerInit();
		}
		
		void SetButtonToCanStart()
		{
			btnStart.Enabled = true;
			btnStop.Enabled = false;
			listBox.SelectedIndex = -1;
			loopStartLine = 0;
		}
		
		void SetButtonToCanStop()
		{
			btnStart.Enabled = false;
			btnStop.Enabled = true;
		}
		
		private void timerInit()
		{
		    Timer1.Tick += new EventHandler(TimerToDo);		   		    
		}
		
		private void timerStart()
		{
			int interval = Int32.Parse(comInterval.Text) * 1000;
			Timer1.Interval = interval;
			Timer1.Enabled = true;   		    
		}
		
		private void timerStop()
		{
			Timer1.Enabled = false;   		    
		}		
		
		private void TimerToDo(object Sender, EventArgs e)   
		{
			if (listBox.SelectedIndex >= listBox.Items.Count - 1)
			{
				timerStop();
				txtMsg.Text += getTimeString() + " => ====== Finish ======\r\n\r\n";
				SetButtonToCanStart();
			}
			else
			{
				listBox.SelectedIndex ++;
				String cmd = listBox.Items[listBox.SelectedIndex].ToString();
				if (cmd.Trim().Length > 0)
				{
					int interval = Int32.Parse(comInterval.Text) * 1000;
					Timer1.Interval = interval;
					
					if (cmd.IndexOf("loop_start") != -1 || cmd.IndexOf("LOOP_START") != -1)
					{
						loopStartLine = listBox.SelectedIndex + 1;
					}
					else if (cmd.IndexOf("loop_end") != -1 || cmd.IndexOf("LOOP_END") != -1)
					{
						listBox.SelectedIndex = loopStartLine;
					}
					else if (cmd.IndexOf("sleep") != -1 || cmd.IndexOf("SLEEP") != -1)
					{						
						string[] words = cmd.Trim().Split(' ');
						int t = Int32.Parse(words[1]);						
						txtMsg.Text += getTimeString() + " => sleep " + t.ToString() + "\r\n";
						Timer1.Interval = t*1000;
					}					
					else
					{
						if (ADBClass.ADBCommand(cmd) == true)
						{
							txtMsg.Text += getTimeString() + " => " + listBox.Items[listBox.SelectedIndex] + "\r\n";
						}
						else
						{
							timerStop();
							txtMsg.Text += getTimeString() + " => " + listBox.Items[listBox.SelectedIndex] + "\r\n";
							txtMsg.Text += getTimeString() + " => ADB run failed! Stop script....\r\n\r\n";
						}
					}					
				}					
			}
						
			txtMsg.Focus(); 
			txtMsg.Select(txtMsg.TextLength, 0); 
			txtMsg.ScrollToCaret(); 
		}

		void BtnLoadClick(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "Select file";
			dialog.InitialDirectory = ".\\";
			dialog.Filter = "script files (*.script)|*.script";
			
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				txtPath.Text = dialog.FileName;
				
				listBox.Items.Clear();
				string[] lines = File.ReadAllLines(txtPath.Text);
				listBox.Items.AddRange(lines);
			}
		}
		
		void BtnClearClick(object sender, EventArgs e)
		{
			txtMsg.Text = "";
		}

		String getTimeString()
		{
			return System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"); 
		}

		void BtnStartClick(object sender, EventArgs e)
		{
			if (listBox.Items.Count == 0)
			{
				MessageBox.Show("Please first load script file!");
				return;
			}
			
			if (ADBClass.bConnectResult == false)
			{
				MessageBox.Show("Please first connect to DUT!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			txtMsg.Text += getTimeString() + " ====== Start ======\r\n";			
			SetButtonToCanStop();
			timerStart();
		}
		
		void BtnStopClick(object sender, EventArgs e)
		{
			timerStop();
			txtMsg.Text += getTimeString() + " ====== Stop ======\r\n\r\n";
			SetButtonToCanStart();	

			txtMsg.Focus(); 
			txtMsg.Select(txtMsg.TextLength, 0); 
			txtMsg.ScrollToCaret(); 
		}
		
		void ScriptFormFormClosing(object sender, FormClosingEventArgs e)
		{
			timerStop();
		}
		void LabExampleClick(object sender, EventArgs e)
		{
			listBox.Items.Clear();	
			listBox.Items.Add("loop_start");
			listBox.Items.Add("shell input keyevent KEYCODE_DPAD_DOWN");
			listBox.Items.Add("shell input keyevent KEYCODE_DPAD_UP");
			listBox.Items.Add("shell am start -a android.settings.SETTINGS");
			listBox.Items.Add("sleep 5");
			listBox.Items.Add("shell input keyevent KEYCODE_DPAD_DOWN");
			listBox.Items.Add("shell input keyevent KEYCODE_DPAD_UP");
			listBox.Items.Add("shell input keyevent KEYCODE_HOME");
			listBox.Items.Add("sleep 5");
			listBox.Items.Add("loop_end");
		}		
	}
}
