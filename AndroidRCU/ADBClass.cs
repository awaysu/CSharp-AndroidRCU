using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Configuration;

namespace AndroidRCU
{

	public sealed class ADBClass
	{
		public static Boolean bConnectResult = false;		
		public static Boolean bExist = true;
		public static String ADB_CMD;
		static String CONFIG_IP = "adbip";
		static String CONFIG_PORT = "adbport";
		static int TIMEOUT = 3000;
		
		public static String STR_ERROR = ERR_NO_ERROR;
		public const String ERR_NO_ERROR="No error!";
		public const String ERR_ADB_NOT_EXIST="Can't find ADB!\r\nPlease download adb.exe, AdbWinApi.dll & AdbWinUsbApi.dll to ";
		public const String ERR_CONNECT_FAILED="ADB connect failed!\r\n Please confirm DUT of IP address & port!";
		public const String ERR_SYSRUN_FAILED="System run failed!";
		
		public static Boolean ADBInit(String path)
		{
			bExist = true;
			STR_ERROR = ERR_NO_ERROR;
			
			ADB_CMD= System.Environment.CurrentDirectory +"\\adb.exe";
						
			if (File.Exists(ADB_CMD) == false)
			{
				bExist = false;
				STR_ERROR = ERR_ADB_NOT_EXIST + System.Environment.CurrentDirectory;
			}
			
			return bExist;
		}
		
		public static String GetConfig(String name)
		{
			String aa= ConfigurationManager.AppSettings[name];			
			return ConfigurationManager.AppSettings[name];
		}
		
		public static void SaveConfig(String name, String para)
		{
			Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			config.AppSettings.Settings.Remove(name);			
			config.AppSettings.Settings.Add(name, para);
			config.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection("appSettings"); 
		}
		
		public static Boolean ADBConnect(String ip, String port)
		{
			String cmd = " connect " + ip + ":" + port;
			Boolean bResult = false;

			ADBDIsconnect();
			
			if (exeFun(ADB_CMD, cmd) == true)
			{				
				SaveConfig(CONFIG_IP, ip);
				SaveConfig(CONFIG_PORT, port);
				
				bResult = true;
				STR_ERROR = ERR_NO_ERROR;
			}
			else
				STR_ERROR = ERR_CONNECT_FAILED;

			return bResult;
		}
				
		public static void ADBDIsconnect()
		{
			exeFun(ADB_CMD, " disconnect");
		}
		
		public static Boolean ADBCommand(String arg)
		{			
			if (bConnectResult == false)
				return false;
			
			String cmd = " " + arg;
			return exeFun(ADB_CMD, cmd);
		}
		
		public static Boolean isADBConnected()
		{			
			String cmd = "shell ls";
			bConnectResult = exeFun(ADB_CMD, cmd);
			return bConnectResult;
		}
		
		public static Boolean exeFun(String cmd, String arg)
		{			
			Boolean bResult = false;
			STR_ERROR = ERR_SYSRUN_FAILED;
			
			if (bExist == false)
			{
				STR_ERROR = ERR_ADB_NOT_EXIST;
				return bResult;
			}
			
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
			startInfo.FileName = cmd;
			startInfo.Arguments = arg;
			process.StartInfo = startInfo;
			process.Start();
			//process.WaitForExit();
			
			if(!process.WaitForExit(TIMEOUT))
			{ 
			    process.Kill();
			}
			
			if (process.ExitCode == 0)
			{
				bResult = true;
				STR_ERROR = ERR_NO_ERROR;
			}
			
			return bResult;
		}

	}
	
}

