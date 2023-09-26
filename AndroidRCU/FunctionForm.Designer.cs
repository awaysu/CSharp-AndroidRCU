/*
 * 由SharpDevelop创建。
 * 用户： Awaysu
 * 日期: 08/22/2023
 * 时间: PM 05:01
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace AndroidRCU
{
	partial class FunctionForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnKeycode;
		private System.Windows.Forms.ComboBox comKeycode;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtString;
		private System.Windows.Forms.Button btnString;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtCommon1;
		private System.Windows.Forms.Button btnCom1;
		private System.Windows.Forms.TextBox txtCommon3;
		private System.Windows.Forms.Button btnCom3;
		private System.Windows.Forms.TextBox txtCommon2;
		private System.Windows.Forms.Button btnCom2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnLPower;
		private System.Windows.Forms.Button btnSPower;
		private System.Windows.Forms.Button btnBtOff;
		private System.Windows.Forms.Button btnBtOn;
		private System.Windows.Forms.Button btnWifiOff;
		private System.Windows.Forms.Button btnWifiOn;
		private System.Windows.Forms.Button btnCec;
		private System.Windows.Forms.Button btnSetting;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox txtCommand;
		private System.Windows.Forms.Button btnCommand;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnDown;
		private System.Windows.Forms.Button btnUp;
		private System.Windows.Forms.Button btnRoot;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnKeycode = new System.Windows.Forms.Button();
			this.comKeycode = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtString = new System.Windows.Forms.TextBox();
			this.btnString = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txtCommon3 = new System.Windows.Forms.TextBox();
			this.btnCom3 = new System.Windows.Forms.Button();
			this.txtCommon2 = new System.Windows.Forms.TextBox();
			this.btnCom2 = new System.Windows.Forms.Button();
			this.txtCommon1 = new System.Windows.Forms.TextBox();
			this.btnCom1 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnRoot = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			this.btnEnter = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnLPower = new System.Windows.Forms.Button();
			this.btnSPower = new System.Windows.Forms.Button();
			this.btnBtOff = new System.Windows.Forms.Button();
			this.btnBtOn = new System.Windows.Forms.Button();
			this.btnWifiOff = new System.Windows.Forms.Button();
			this.btnCec = new System.Windows.Forms.Button();
			this.btnWifiOn = new System.Windows.Forms.Button();
			this.btnSetting = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.txtCommand = new System.Windows.Forms.TextBox();
			this.btnCommand = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnKeycode);
			this.groupBox1.Controls.Add(this.comKeycode);
			this.groupBox1.Location = new System.Drawing.Point(19, 238);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(632, 90);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Send Keycode";
			// 
			// btnKeycode
			// 
			this.btnKeycode.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnKeycode.Location = new System.Drawing.Point(468, 28);
			this.btnKeycode.Name = "btnKeycode";
			this.btnKeycode.Size = new System.Drawing.Size(151, 44);
			this.btnKeycode.TabIndex = 1;
			this.btnKeycode.Text = "Send";
			this.btnKeycode.UseVisualStyleBackColor = true;
			this.btnKeycode.Click += new System.EventHandler(this.BtnKeycodeClick);
			// 
			// comKeycode
			// 
			this.comKeycode.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comKeycode.FormattingEnabled = true;
			this.comKeycode.Items.AddRange(new object[] {
			"KEYCODE_MENU",
			"KEYCODE_SOFT_RIGHT",
			"KEYCODE_HOME",
			"KEYCODE_BACK",
			"KEYCODE_CALL",
			"KEYCODE_ENDCALL",
			"KEYCODE_0",
			"KEYCODE_1",
			"KEYCODE_2",
			"KEYCODE_3",
			"KEYCODE_4",
			"KEYCODE_5",
			"KEYCODE_6",
			"KEYCODE_7",
			"KEYCODE_8",
			"KEYCODE_9",
			"KEYCODE_STAR",
			"KEYCODE_POUND",
			"KEYCODE_DPAD_UP",
			"KEYCODE_DPAD_DOWN",
			"KEYCODE_DPAD_LEFT",
			"KEYCODE_DPAD_RIGHT",
			"KEYCODE_DPAD_CENTER",
			"KEYCODE_VOLUME_UP",
			"KEYCODE_VOLUME_DOWN",
			"KEYCODE_POWER",
			"KEYCODE_CAMERA",
			"KEYCODE_CLEAR",
			"KEYCODE_A",
			"KEYCODE_B",
			"KEYCODE_C",
			"KEYCODE_D",
			"KEYCODE_E",
			"KEYCODE_F",
			"KEYCODE_G",
			"KEYCODE_H",
			"KEYCODE_I",
			"KEYCODE_J",
			"KEYCODE_K",
			"KEYCODE_L",
			"KEYCODE_M",
			"KEYCODE_N",
			"KEYCODE_O",
			"KEYCODE_P",
			"KEYCODE_Q",
			"KEYCODE_R",
			"KEYCODE_S",
			"KEYCODE_T",
			"KEYCODE_U",
			"KEYCODE_V",
			"KEYCODE_W",
			"KEYCODE_X",
			"KEYCODE_Y",
			"KEYCODE_Z",
			"KEYCODE_COMMA",
			"KEYCODE_PERIOD",
			"KEYCODE_ALT_LEFT",
			"KEYCODE_ALT_RIGHT",
			"KEYCODE_SHIFT_LEFT",
			"KEYCODE_SHIFT_RIGHT",
			"KEYCODE_TAB",
			"KEYCODE_SPACE",
			"KEYCODE_SYM",
			"KEYCODE_EXPLORER",
			"KEYCODE_ENVELOPE",
			"KEYCODE_ENTER",
			"KEYCODE_DEL",
			"KEYCODE_GRAVE",
			"KEYCODE_MINUS",
			"KEYCODE_EQUALS",
			"KEYCODE_LEFT_BRACKET",
			"KEYCODE_RIGHT_BRACKET",
			"KEYCODE_BACKSLASH",
			"KEYCODE_SEMICOLON",
			"KEYCODE_APOSTROPHE",
			"KEYCODE_SLASH",
			"KEYCODE_AT",
			"KEYCODE_NUM",
			"KEYCODE_HEADSETHOOK",
			"KEYCODE_FOCUS",
			"KEYCODE_PLUS",
			"KEYCODE_MENU",
			"KEYCODE_NOTIFICATION",
			"KEYCODE_SEARCH",
			"KEYCODE_MEDIA_PLAY_PAUSE",
			"KEYCODE_MEDIA_STOP",
			"KEYCODE_MEDIA_NEXT",
			"KEYCODE_MEDIA_PREVIOUS",
			"KEYCODE_MEDIA_REWIND",
			"KEYCODE_MEDIA_FAST_FORWARD",
			"KEYCODE_MUTE",
			"KEYCODE_PAGE_UP",
			"KEYCODE_PAGE_DOWN",
			"KEYCODE_PICTSYMBOLS",
			"KEYCODE_MOVE_HOME",
			"KEYCODE_MOVE_END",
			"KEYCODE_MEDIA_PLAY",
			"KEYCODE_MEDIA_PAUSE",
			"KEYCODE_APP_SWITCH"});
			this.comKeycode.Location = new System.Drawing.Point(19, 28);
			this.comKeycode.Name = "comKeycode";
			this.comKeycode.Size = new System.Drawing.Size(434, 40);
			this.comKeycode.TabIndex = 1;
			this.comKeycode.Text = "KEYCODE_ENTER";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtString);
			this.groupBox2.Controls.Add(this.btnString);
			this.groupBox2.Location = new System.Drawing.Point(19, 133);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(632, 90);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Send String";
			// 
			// txtString
			// 
			this.txtString.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtString.Location = new System.Drawing.Point(19, 28);
			this.txtString.Name = "txtString";
			this.txtString.Size = new System.Drawing.Size(434, 46);
			this.txtString.TabIndex = 2;
			// 
			// btnString
			// 
			this.btnString.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnString.Location = new System.Drawing.Point(468, 28);
			this.btnString.Name = "btnString";
			this.btnString.Size = new System.Drawing.Size(151, 46);
			this.btnString.TabIndex = 1;
			this.btnString.Text = "Send";
			this.btnString.UseVisualStyleBackColor = true;
			this.btnString.Click += new System.EventHandler(this.BtnStringClick);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.txtCommon3);
			this.groupBox3.Controls.Add(this.btnCom3);
			this.groupBox3.Controls.Add(this.txtCommon2);
			this.groupBox3.Controls.Add(this.btnCom2);
			this.groupBox3.Controls.Add(this.txtCommon1);
			this.groupBox3.Controls.Add(this.btnCom1);
			this.groupBox3.Location = new System.Drawing.Point(19, 346);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(632, 234);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Commonly used command";
			// 
			// txtCommon3
			// 
			this.txtCommon3.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtCommon3.Location = new System.Drawing.Point(19, 165);
			this.txtCommon3.Name = "txtCommon3";
			this.txtCommon3.Size = new System.Drawing.Size(434, 46);
			this.txtCommon3.TabIndex = 6;
			this.txtCommon3.Text = "shell am start -a com.google.android.exoplayer.demo.action.VIEW -d file:///storag" +
	"e/8034-090D/h264-480p24.ts";
			// 
			// btnCom3
			// 
			this.btnCom3.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCom3.Location = new System.Drawing.Point(468, 165);
			this.btnCom3.Name = "btnCom3";
			this.btnCom3.Size = new System.Drawing.Size(151, 46);
			this.btnCom3.TabIndex = 5;
			this.btnCom3.Text = "Send";
			this.btnCom3.UseVisualStyleBackColor = true;
			this.btnCom3.Click += new System.EventHandler(this.BtnCom3Click);
			// 
			// txtCommon2
			// 
			this.txtCommon2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtCommon2.Location = new System.Drawing.Point(19, 99);
			this.txtCommon2.Name = "txtCommon2";
			this.txtCommon2.Size = new System.Drawing.Size(434, 46);
			this.txtCommon2.TabIndex = 4;
			this.txtCommon2.Text = "shell screencap -p /data/screen.png";
			// 
			// btnCom2
			// 
			this.btnCom2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCom2.Location = new System.Drawing.Point(468, 99);
			this.btnCom2.Name = "btnCom2";
			this.btnCom2.Size = new System.Drawing.Size(151, 46);
			this.btnCom2.TabIndex = 3;
			this.btnCom2.Text = "Send";
			this.btnCom2.UseVisualStyleBackColor = true;
			this.btnCom2.Click += new System.EventHandler(this.BtnCom2Click);
			// 
			// txtCommon1
			// 
			this.txtCommon1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtCommon1.Location = new System.Drawing.Point(19, 36);
			this.txtCommon1.Name = "txtCommon1";
			this.txtCommon1.Size = new System.Drawing.Size(434, 46);
			this.txtCommon1.TabIndex = 2;
			this.txtCommon1.Text = "shell am start -a android.intent.action.VIEW -d \"http://www.youtube.com\"";
			// 
			// btnCom1
			// 
			this.btnCom1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCom1.Location = new System.Drawing.Point(468, 36);
			this.btnCom1.Name = "btnCom1";
			this.btnCom1.Size = new System.Drawing.Size(151, 46);
			this.btnCom1.TabIndex = 1;
			this.btnCom1.Text = "Send";
			this.btnCom1.UseVisualStyleBackColor = true;
			this.btnCom1.Click += new System.EventHandler(this.BtnCom1Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnRoot);
			this.groupBox4.Controls.Add(this.btnHome);
			this.groupBox4.Controls.Add(this.btnBack);
			this.groupBox4.Controls.Add(this.btnEnter);
			this.groupBox4.Controls.Add(this.btnRight);
			this.groupBox4.Controls.Add(this.btnLeft);
			this.groupBox4.Controls.Add(this.btnDown);
			this.groupBox4.Controls.Add(this.btnUp);
			this.groupBox4.Controls.Add(this.btnLPower);
			this.groupBox4.Controls.Add(this.btnSPower);
			this.groupBox4.Controls.Add(this.btnBtOff);
			this.groupBox4.Controls.Add(this.btnBtOn);
			this.groupBox4.Controls.Add(this.btnWifiOff);
			this.groupBox4.Controls.Add(this.btnCec);
			this.groupBox4.Controls.Add(this.btnWifiOn);
			this.groupBox4.Controls.Add(this.btnSetting);
			this.groupBox4.Location = new System.Drawing.Point(679, 28);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(449, 552);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Commonly used keys";
			// 
			// btnRoot
			// 
			this.btnRoot.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnRoot.Location = new System.Drawing.Point(15, 479);
			this.btnRoot.Name = "btnRoot";
			this.btnRoot.Size = new System.Drawing.Size(201, 46);
			this.btnRoot.TabIndex = 25;
			this.btnRoot.Text = "ADB Root";
			this.btnRoot.UseVisualStyleBackColor = true;
			this.btnRoot.Click += new System.EventHandler(this.BtnRootClick);
			// 
			// btnHome
			// 
			this.btnHome.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnHome.Location = new System.Drawing.Point(15, 413);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(201, 46);
			this.btnHome.TabIndex = 24;
			this.btnHome.Text = "Home";
			this.btnHome.UseVisualStyleBackColor = true;
			this.btnHome.Click += new System.EventHandler(this.BtnHomeClick);
			// 
			// btnBack
			// 
			this.btnBack.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnBack.Location = new System.Drawing.Point(15, 345);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(201, 46);
			this.btnBack.TabIndex = 23;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.BtnBackClick);
			// 
			// btnEnter
			// 
			this.btnEnter.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnEnter.Location = new System.Drawing.Point(15, 282);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(201, 46);
			this.btnEnter.TabIndex = 22;
			this.btnEnter.Text = "Enter";
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.BtnEnterClick);
			// 
			// btnRight
			// 
			this.btnRight.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnRight.Location = new System.Drawing.Point(15, 219);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(201, 46);
			this.btnRight.TabIndex = 21;
			this.btnRight.Text = "Right";
			this.btnRight.UseVisualStyleBackColor = true;
			this.btnRight.Click += new System.EventHandler(this.BtnRightClick);
			// 
			// btnLeft
			// 
			this.btnLeft.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnLeft.Location = new System.Drawing.Point(15, 156);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(201, 46);
			this.btnLeft.TabIndex = 20;
			this.btnLeft.Text = "Left";
			this.btnLeft.UseVisualStyleBackColor = true;
			this.btnLeft.Click += new System.EventHandler(this.BtnLeftClick);
			// 
			// btnDown
			// 
			this.btnDown.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnDown.Location = new System.Drawing.Point(15, 90);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(201, 46);
			this.btnDown.TabIndex = 19;
			this.btnDown.Text = "Down";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.BtnDownClick);
			// 
			// btnUp
			// 
			this.btnUp.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnUp.Location = new System.Drawing.Point(15, 28);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(201, 46);
			this.btnUp.TabIndex = 18;
			this.btnUp.Text = "Up";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.BtnUpClick);
			// 
			// btnLPower
			// 
			this.btnLPower.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnLPower.Location = new System.Drawing.Point(231, 479);
			this.btnLPower.Name = "btnLPower";
			this.btnLPower.Size = new System.Drawing.Size(201, 46);
			this.btnLPower.TabIndex = 10;
			this.btnLPower.Text = "Long Power";
			this.btnLPower.UseVisualStyleBackColor = true;
			this.btnLPower.Click += new System.EventHandler(this.BtnLPowerClick);
			// 
			// btnSPower
			// 
			this.btnSPower.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSPower.Location = new System.Drawing.Point(232, 413);
			this.btnSPower.Name = "btnSPower";
			this.btnSPower.Size = new System.Drawing.Size(201, 46);
			this.btnSPower.TabIndex = 9;
			this.btnSPower.Text = "Short Power";
			this.btnSPower.UseVisualStyleBackColor = true;
			this.btnSPower.Click += new System.EventHandler(this.BtnSPowerClick);
			// 
			// btnBtOff
			// 
			this.btnBtOff.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnBtOff.Location = new System.Drawing.Point(231, 345);
			this.btnBtOff.Name = "btnBtOff";
			this.btnBtOff.Size = new System.Drawing.Size(201, 46);
			this.btnBtOff.TabIndex = 8;
			this.btnBtOff.Text = "BT Off";
			this.btnBtOff.UseVisualStyleBackColor = true;
			this.btnBtOff.Click += new System.EventHandler(this.BtnBtOffClick);
			// 
			// btnBtOn
			// 
			this.btnBtOn.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnBtOn.Location = new System.Drawing.Point(231, 282);
			this.btnBtOn.Name = "btnBtOn";
			this.btnBtOn.Size = new System.Drawing.Size(201, 46);
			this.btnBtOn.TabIndex = 7;
			this.btnBtOn.Text = "BT On";
			this.btnBtOn.UseVisualStyleBackColor = true;
			this.btnBtOn.Click += new System.EventHandler(this.BtnBtOnClick);
			// 
			// btnWifiOff
			// 
			this.btnWifiOff.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnWifiOff.Location = new System.Drawing.Point(232, 219);
			this.btnWifiOff.Name = "btnWifiOff";
			this.btnWifiOff.Size = new System.Drawing.Size(200, 46);
			this.btnWifiOff.TabIndex = 6;
			this.btnWifiOff.Text = "WIFI Off";
			this.btnWifiOff.UseVisualStyleBackColor = true;
			this.btnWifiOff.Click += new System.EventHandler(this.BtnWifiOffClick);
			// 
			// btnCec
			// 
			this.btnCec.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCec.Location = new System.Drawing.Point(231, 90);
			this.btnCec.Name = "btnCec";
			this.btnCec.Size = new System.Drawing.Size(200, 46);
			this.btnCec.TabIndex = 4;
			this.btnCec.Text = "CEC";
			this.btnCec.UseVisualStyleBackColor = true;
			this.btnCec.Click += new System.EventHandler(this.BtnCecClick);
			// 
			// btnWifiOn
			// 
			this.btnWifiOn.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnWifiOn.Location = new System.Drawing.Point(232, 156);
			this.btnWifiOn.Name = "btnWifiOn";
			this.btnWifiOn.Size = new System.Drawing.Size(201, 46);
			this.btnWifiOn.TabIndex = 5;
			this.btnWifiOn.Text = "WIFI On";
			this.btnWifiOn.UseVisualStyleBackColor = true;
			this.btnWifiOn.Click += new System.EventHandler(this.BtnWifiOnClick);
			// 
			// btnSetting
			// 
			this.btnSetting.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSetting.Location = new System.Drawing.Point(231, 28);
			this.btnSetting.Name = "btnSetting";
			this.btnSetting.Size = new System.Drawing.Size(201, 46);
			this.btnSetting.TabIndex = 3;
			this.btnSetting.Text = "Setting";
			this.btnSetting.UseVisualStyleBackColor = true;
			this.btnSetting.Click += new System.EventHandler(this.BtnSettingClick);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.txtCommand);
			this.groupBox5.Controls.Add(this.btnCommand);
			this.groupBox5.Location = new System.Drawing.Point(19, 28);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(632, 90);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Send Commad";
			// 
			// txtCommand
			// 
			this.txtCommand.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtCommand.Location = new System.Drawing.Point(19, 28);
			this.txtCommand.Name = "txtCommand";
			this.txtCommand.Size = new System.Drawing.Size(434, 46);
			this.txtCommand.TabIndex = 2;
			// 
			// btnCommand
			// 
			this.btnCommand.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnCommand.Location = new System.Drawing.Point(468, 28);
			this.btnCommand.Name = "btnCommand";
			this.btnCommand.Size = new System.Drawing.Size(151, 46);
			this.btnCommand.TabIndex = 1;
			this.btnCommand.Text = "Send";
			this.btnCommand.UseVisualStyleBackColor = true;
			this.btnCommand.Click += new System.EventHandler(this.BtnCommandClick);
			// 
			// FunctionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1153, 598);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FunctionForm";
			this.Text = "Professional Mode";
			this.Load += new System.EventHandler(this.FunctionFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
