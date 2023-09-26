/*
 * 由SharpDevelop创建。
 * 用户： Awaysu
 * 日期: 08/21/2023
 * 时间: PM 06:21
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace AndroidRCU
{
	partial class ConnectForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.Label label1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectForm));
			this.btnConnect = new System.Windows.Forms.Button();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnConnect
			// 
			this.btnConnect.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnConnect.Location = new System.Drawing.Point(301, 160);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(181, 43);
			this.btnConnect.TabIndex = 7;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.BtnConnectClick);
			// 
			// txtPort
			// 
			this.txtPort.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPort.Location = new System.Drawing.Point(165, 79);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(317, 46);
			this.txtPort.TabIndex = 5;
			this.txtPort.Text = "5555";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(12, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(166, 74);
			this.label2.TabIndex = 3;
			this.label2.Text = "Port :";
			// 
			// txtIP
			// 
			this.txtIP.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtIP.Location = new System.Drawing.Point(165, 18);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(317, 46);
			this.txtIP.TabIndex = 6;
			this.txtIP.Text = "192.168.1.100";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 74);
			this.label1.TabIndex = 4;
			this.label1.Text = "IP Adress :";
			// 
			// ConnectForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 226);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtIP);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ConnectForm";
			this.Text = "ADB connect";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnectFormFormClosed);
			this.Load += new System.EventHandler(this.ConnectFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
