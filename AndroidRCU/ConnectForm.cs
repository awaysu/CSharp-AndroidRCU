/*
 * 由SharpDevelop创建。
 * 用户： Awaysu
 * 日期: 08/21/2023
 * 时间: PM 06:21
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AndroidRCU
{
	/// <summary>
	/// Description of ConnectForm.
	/// </summary>
	public partial class ConnectForm : Form
	{

		public ConnectForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ConnectFormLoad(object sender, EventArgs e)
		{
			String CONFIG_IP = "adbip";
			String CONFIG_PORT = "adbport";

			String ip = ADBClass.GetConfig(CONFIG_IP);
			String port = ADBClass.GetConfig(CONFIG_PORT);
			
			if (ip != null )				
				txtIP.Text = ip;
			
			if (port != null )	
				txtPort.Text = port;
		}
		
		void BtnConnectClick(object sender, EventArgs e)
		{
			
			String ADB_CMD= System.Environment.CurrentDirectory +"\\adb.exe";
			ADBClass.bConnectResult = false;
			if (ADBClass.ADBInit(ADB_CMD) == false)
			{
				MessageBox.Show("[Failed] " + ADBClass.STR_ERROR, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			if (ADBClass.ADBConnect(txtIP.Text, txtPort.Text) == false)
			{
				MessageBox.Show("[Failed] " + ADBClass.STR_ERROR, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			//MessageBox.Show("Connection Succeeded!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.None);
			ADBClass.bConnectResult = true;

			this.Close();
		}
		
		void ConnectFormFormClosed(object sender, FormClosedEventArgs e)
		{
			//if (ADBClass.bConnectResult == false)
				//Application.Exit();
		}

		
	}
}
