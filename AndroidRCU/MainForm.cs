/*
 * 由SharpDevelop创建。
 * 用户： Awaysu
 * 日期: 08/21/2023
 * 时间: PM 03:10
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Configuration;
using System.Reflection;
	
namespace AndroidRCU
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	

	public partial class MainForm : Form
	{
		MainMenu MyMenu;
			
		int UP_X=140;
		int UP_Y=50;
		int DOWN_X=140;
		int DOWN_Y=230;
		int LEFT_X=50;
		int LEFT_Y=140;
		int RIGHT_X=220;
		int RIGHT_Y=140;
		int OK_X=140;
		int OK_Y=140;
		int HOME_X=70;
		int HOME_Y=300;
		int BACK_X=210;
		int BACK_Y=300;
				
		public static DateTime GetLinkerTimestampUtc(Assembly assembly)
		{
		    var location = assembly.Location;
		    return GetLinkerTimestampUtc(location);
		}
		
		public static DateTime GetLinkerTimestampUtc(string filePath)
		{
		    const int peHeaderOffset = 60;
		    const int linkerTimestampOffset = 8;
		    var bytes = new byte[2048];
		
		    using (var file = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
		    {
		        file.Read(bytes, 0, bytes.Length);
		    }
		
		    var headerPos = BitConverter.ToInt32(bytes, peHeaderOffset);
		    var secondsSince1970 = BitConverter.ToInt32(bytes, headerPos + linkerTimestampOffset);
		    var dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		    return dt.AddSeconds(secondsSince1970);
		}
		
		public static String GetBuild()
		{
			DateTime dt = GetLinkerTimestampUtc(Assembly.GetExecutingAssembly());
			String ret = dt.Year.ToString() + dt.Month.ToString("00") + dt.Day.ToString("00");
			return ret;
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{	
		   picSelect.Location=new Point(-150, -50);
		   
		   this.Width = pictureBox1.Width;
		   this.Height = pictureBox1.Height + 40;
		   
		   float a = ScreenDPIHelper.ScaleX;
		   float b = ScreenDPIHelper.ScaleX;
		  
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			//this.MinimizeBox = false;
		   
			CreateMenu();
			ShowConnectForm();
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{

		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if (ADBClass.bConnectResult == true)
				ADBClass.ADBDIsconnect();
		}
		
		void ShowConnectForm()
		{			
			this.Enabled = false;
            ConnectForm connectF = new ConnectForm();
            connectF.TopMost = true;
            connectF.FormClosed += connectF_FormClosed;
            connectF.Show();
		}
		
	    private void connectF_FormClosed(object sender, FormClosedEventArgs e)
	    {
	        this.Enabled = true;
	        this.Focus();
	    }
	    
	    void CreateMenu()
	    {

			MyMenu  = new MainMenu(); 
			
			MenuItem m1 = new MenuItem("Menu"); 
			MyMenu.MenuItems.Add(m1); 

			MenuItem m2 = new MenuItem("Help"); 
			MyMenu.MenuItems.Add(m2); 
			
			MenuItem subm1 = new MenuItem("ADB Connect"); 
			m1.MenuItems.Add(subm1); 
			
			MenuItem subm2 = new MenuItem("Script"); 
			m1.MenuItems.Add(subm2); 
			
			MenuItem subm3 = new MenuItem("Professional Mode"); 
			m1.MenuItems.Add(subm3); 			
			 
			m1.MenuItems.Add("-"); 
			
			MenuItem subm4 = new MenuItem("Exit"); 
			m1.MenuItems.Add(subm4); 
			
			
			MenuItem subm5 = new MenuItem("Hotkey"); 
			m2.MenuItems.Add(subm5); 

			MenuItem subm6 = new MenuItem("About"); 
			m2.MenuItems.Add(subm6); 
			
			subm1.Click += new EventHandler(MMConnectClick);
		    subm2.Click += new EventHandler(MMScriptClick); 
		    subm3.Click += new EventHandler(MMCmdClick);
		    subm4.Click += new EventHandler(MMExitClick);    
		    subm5.Click += new EventHandler(MMHowClick);
		    subm6.Click += new EventHandler(MMAboutClick);
		    
			Menu = MyMenu; 
	    }
		
		protected void MMAboutClick(object who, EventArgs e) 
		{
			String title = "About [Android RCU]";
			String build = GetBuild();
			String author = "awaysu@gmail.com";

			
			System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
			System.Diagnostics.FileVersionInfo fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);
			String version = fvi.FileVersion;

			String show = "Version: " + version;
			show += "\r\nBuild: " + build;
			show += "\r\nAuthor: " + author;
			MessageBox.Show(show, title);
			pictureBox1.Focus();
		}
		
		protected void MMConnectClick(object who, EventArgs e) 
		{
			ShowConnectForm();
		} 
		
		protected void MMCmdClick(object who, EventArgs e) 
		{
			if (ADBClass.bConnectResult == false)
			{
				MessageBox.Show("Please first connect to DUT!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			this.Enabled = false;
            FunctionForm funF = new FunctionForm();
            funF.TopMost = true;
            funF.FormClosed += funF_FormClosed;
            funF.Show();		
		} 
		
		protected void MMScriptClick(object who, EventArgs e) 
		{
			if (ADBClass.bConnectResult == false)
			{
				MessageBox.Show("Please first connect to DUT!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			this.Enabled = false;
            ScriptForm funF = new ScriptForm();
            funF.TopMost = true;
            funF.FormClosed += funF_FormClosed;
            funF.Show();		
		} 

		protected void MMHowClick(object who, EventArgs e) 
		{
			String show = "Up    => keyboard [Up]\r\n";
			show += "Down  => keyboard [Down]\r\n";
			show += "Left  => keyboard [Left]\r\n";
			show += "Right => keyboard [Right]\r\n";
			show += "OK    => keyboard [Enter]\r\n";
			show += "Back  => keyboard [Backspace]\r\n";
			show += "Home  => keyboard [Esc]\r\n";
			MessageBox.Show(show, "Hotkey");
		}
		
		protected void MMExitClick(object who, EventArgs e) 
		{
			Application.Exit();
		}
		
	    private void funF_FormClosed(object sender, FormClosedEventArgs e)
	    {
	        this.Enabled = true;
	        this.Focus();
	    }
	    
		void RunADB_UP()
		{		
			picSelect.Location=new Point(133, 42);
			ADBClass.ADBCommand("shell input keyevent KEYCODE_DPAD_UP");
			picSelect.Location=new Point(-50, -50);
		}
		
		void RunADB_DOWN()
		{
			picSelect.Location=new Point(133, 220);
			ADBClass.ADBCommand("shell input keyevent KEYCODE_DPAD_DOWN");
			picSelect.Location=new Point(-50, -50);
		}		

		void RunADB_LEFT()
		{
			picSelect.Location=new Point(42, 130);
			ADBClass.ADBCommand("shell input keyevent KEYCODE_DPAD_LEFT");
			picSelect.Location=new Point(-50, -50);
		}	
		void RunADB_RIGHT()
		{
			picSelect.Location=new Point(223, 130);
			ADBClass.ADBCommand("shell input keyevent KEYCODE_DPAD_RIGHT");
			picSelect.Location=new Point(-50, -50);
		}			
		void RunADB_OK()
		{
			picSelect.Location=new Point(133, 130);
			ADBClass.ADBCommand("shell input keyevent KEYCODE_ENTER");
			picSelect.Location=new Point(-50, -50);
		}	
		void RunADB_HOME()
		{
			picSelect.Location=new Point(63, 292);
			ADBClass.ADBCommand("shell input keyevent KEYCODE_HOME");
			picSelect.Location=new Point(-50, -50);
		}	
		void RunADB_BACK()
		{
			picSelect.Location=new Point(203, 292);
			ADBClass.ADBCommand("shell input keyevent KEYCODE_BACK");
			picSelect.Location=new Point(-50, -50);
		}			

		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if (ADBClass.bConnectResult == false)
				MessageBox.Show("Please first connect to DUT!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			
            switch (e.KeyCode)
            {
                case Keys.Left:
            		RunADB_LEFT();
					break;
                case Keys.Right:
					RunADB_RIGHT();
					break;
                case Keys.Up:
					RunADB_UP();
					break;
                case Keys.Down:
					RunADB_DOWN();
					break;
                case Keys.Enter:
					RunADB_OK();
					break;
                case Keys.Back:
					RunADB_BACK();
					break;
                case Keys.Escape:
					RunADB_HOME();
					break;	
      			default:
            		break;
            }
		}
		
		void mouseClickFun(MouseEventArgs e)
		{
			MouseEventArgs Mouse_e = (MouseEventArgs)e;
			int x = e.Location.X;
			int y = e.Location.Y;
			
			if (ADBClass.bConnectResult == false)
				MessageBox.Show("Please first connect to DUT!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			
			//String debug = e.Location.X + ";" + e.Location.Y;
			//this.Text = debug;

			if (Mouse_e.Button == MouseButtons.Left)
			{
				if (x > UP_X-25 && x < UP_X+25 && y > UP_Y-15 && y< UP_Y+15)
					RunADB_UP();
				else if (x > DOWN_X-25 && x < DOWN_X+25 && y > DOWN_Y-15 && y< DOWN_Y+15)
					RunADB_DOWN();
				else if (x > LEFT_X-25 && x < LEFT_X+25 && y > LEFT_Y-15 && y< LEFT_Y+15)
					RunADB_LEFT();
				else if (x > RIGHT_X-25 && x < RIGHT_X+25 && y > RIGHT_Y-15 && y< RIGHT_Y+15)
					RunADB_RIGHT();
				else if (x > OK_X-35 && x < OK_X+35 && y > OK_Y-35 && y< OK_Y+35)
					RunADB_OK();
				else if (x > HOME_X-40 && x < HOME_X+40 && y > HOME_Y-20 && y< HOME_Y+20)
					RunADB_HOME();
				else if (x > BACK_X-40 && x < BACK_X+40 && y > BACK_Y-20 && y< BACK_Y+20)
					RunADB_BACK();
			}
		}
		
		void PictureBox1MouseClick(object sender, MouseEventArgs e)
		{           
			mouseClickFun(e);
		}
		
		void MainFormMouseClick(object sender, MouseEventArgs e)
		{
			mouseClickFun(e);
		}


	}
}
