/*
 * 由SharpDevelop创建。
 * 用户： Awaysu
 * 日期: 08/22/2023
 * 时间: PM 05:01
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;


namespace AndroidRCU
{
	/// <summary>
	/// Description of FunctionForm.
	/// </summary>
	public partial class FunctionForm : Form
	{
		String CONFIG_COMM1 = "Common1";
		String CONFIG_COMM2 = "Common2";
		String CONFIG_COMM3 = "Common3";
		
		public FunctionForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FunctionFormLoad(object sender, EventArgs e)
		{

			String comm1 = ADBClass.GetConfig(CONFIG_COMM1);
			String comm2 = ADBClass.GetConfig(CONFIG_COMM2);
			String comm3 = ADBClass.GetConfig(CONFIG_COMM3);

			if (comm1 != null )				
				txtCommon1.Text = comm1;
			if (comm2 != null )				
				txtCommon2.Text = comm2;
			if (comm3 != null )				
				txtCommon3.Text = comm3;
		}

		void BtnKeycodeClick(object sender, EventArgs e)
		{
			String cmd = "shell input keyevent " + comKeycode.Text;
			ADBClass.ADBCommand(cmd);
		}
		
		void BtnStringClick(object sender, EventArgs e)
		{
			String cmd = "shell input text \'" + txtString.Text + "\'";
			ADBClass.ADBCommand(cmd);
		}

		void BtnSettingClick(object sender, EventArgs e)
		{			
			ADBClass.ADBCommand("shell am start -a android.settings.SETTINGS");
		}
		void BtnCecClick(object sender, EventArgs e)
		{
			ADBClass.ADBCommand("shell am start -n com.android.tv.settings/.system.InputsActivity");
		}
		void BtnWifiOnClick(object sender, EventArgs e)
		{
			ADBClass.ADBCommand("shell svc wifi enable");
		}
		void BtnWifiOffClick(object sender, EventArgs e)
		{
			ADBClass.ADBCommand("shell svc wifi disable");
		}
		void BtnBtOnClick(object sender, EventArgs e)
		{
			ADBClass.ADBCommand("shell svc bluetooth enable");
		}
		void BtnBtOffClick(object sender, EventArgs e)
		{
			ADBClass.ADBCommand("shell svc bluetooth disable");
		}
		void BtnSPowerClick(object sender, EventArgs e)
		{
			/*
			DialogResult myResult = MessageBox.Show
			("The connection may be interrupted after selecting yes!", "Warning"
			, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			
			if ( myResult  == DialogResult.No)
				return;
			*/
			ADBClass.ADBCommand("shell input keyevent KEYCODE_POWER");
			Thread.Sleep(1000);
			
			if (ADBClass.isADBConnected() == false)
			{
				MessageBox.Show("Already disconnected, please connect again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);				
				ADBClass.ADBDIsconnect();
				this.Close();
			}
		}
		void BtnLPowerClick(object sender, EventArgs e)
		{
			/*
			DialogResult myResult = MessageBox.Show
			("The connection may be interrupted after selecting yes!", "Warning"
			, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			
			if ( myResult  == DialogResult.No)
				return;
			*/
			ADBClass.ADBCommand("shell input keyevent --longpress KEYCODE_POWER");
			Thread.Sleep(1000);
			
			if (ADBClass.isADBConnected() == false)
			{
				MessageBox.Show("Already disconnected, please connect again!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);				
				ADBClass.ADBDIsconnect();
				this.Close();
			}		
		}
		void BtnCommandClick(object sender, EventArgs e)
		{
			ADBClass.ADBCommand(txtCommand.Text);
		}
		void BtnCom1Click(object sender, EventArgs e)
		{
			ADBClass.ADBCommand(txtCommon1.Text);			
			ADBClass.SaveConfig(CONFIG_COMM1, txtCommon1.Text);
		}
		void BtnCom2Click(object sender, EventArgs e)
		{
			ADBClass.ADBCommand(txtCommon2.Text);
			ADBClass.SaveConfig(CONFIG_COMM2, txtCommon2.Text);
		}
		void BtnCom3Click(object sender, EventArgs e)
		{
			ADBClass.ADBCommand(txtCommon3.Text);
			ADBClass.SaveConfig(CONFIG_COMM3, txtCommon3.Text);
		}
		void BtnUpClick(object sender, EventArgs e)
		{
			ADBClass.ADBCommand("shell input keyevent KEYCODE_DPAD_UP");
		}
		void BtnDownClick(object sender, EventArgs e)
		{
			ADBClass.ADBCommand("shell input keyevent KEYCODE_DPAD_DOWN");
		}
		void BtnLeftClick(object sender, EventArgs e)
		{
			ADBClass.ADBCommand("shell input keyevent KEYCODE_DPAD_LEFT");
		}
		void BtnRightClick(object sender, EventArgs e)
		{
			ADBClass.ADBCommand("shell input keyevent KEYCODE_DPAD_RIGHT");
		}
		void BtnEnterClick(object sender, EventArgs e)
		{
			ADBClass.ADBCommand("shell input keyevent KEYCODE_ENTER");
		}
		void BtnBackClick(object sender, EventArgs e)
		{
			ADBClass.ADBCommand("shell input keyevent KEYCODE_BACK");
		}
		void BtnHomeClick(object sender, EventArgs e)
		{
			ADBClass.ADBCommand("shell input keyevent KEYCODE_HOME");
		}
		void BtnRootClick(object sender, EventArgs e)
		{
			ADBClass.ADBCommand("root");
		}
		
		
	}
}
