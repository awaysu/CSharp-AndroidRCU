/*
 * 由SharpDevelop创建。
 * 用户： jason_su
 * 日期: 09/13/2023
 * 时间: AM 10:24
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace AndroidRCU
{
	partial class ScriptForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.TextBox txtMsg;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comInterval;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Timer Timer1;
		private System.Windows.Forms.Label labExample;
		
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
			this.btnLoad = new System.Windows.Forms.Button();
			this.listBox = new System.Windows.Forms.ListBox();
			this.txtMsg = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comInterval = new System.Windows.Forms.ComboBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.labExample = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnLoad.Location = new System.Drawing.Point(626, 15);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(107, 41);
			this.btnLoad.TabIndex = 1;
			this.btnLoad.Text = "Path";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.BtnLoadClick);
			// 
			// listBox
			// 
			this.listBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 24;
			this.listBox.Location = new System.Drawing.Point(22, 142);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(584, 340);
			this.listBox.TabIndex = 2;
			// 
			// txtMsg
			// 
			this.txtMsg.Location = new System.Drawing.Point(22, 504);
			this.txtMsg.Multiline = true;
			this.txtMsg.Name = "txtMsg";
			this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtMsg.Size = new System.Drawing.Size(584, 170);
			this.txtMsg.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(22, 83);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(212, 32);
			this.label1.TabIndex = 5;
			this.label1.Text = "Interval (Sec) :";
			// 
			// comInterval
			// 
			this.comInterval.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.comInterval.FormattingEnabled = true;
			this.comInterval.Items.AddRange(new object[] {
			"1",
			"2",
			"3",
			"4",
			"5",
			"6",
			"7",
			"8",
			"9",
			"10"});
			this.comInterval.Location = new System.Drawing.Point(200, 83);
			this.comInterval.Name = "comInterval";
			this.comInterval.Size = new System.Drawing.Size(75, 36);
			this.comInterval.TabIndex = 6;
			this.comInterval.Text = "3";
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnStart.Location = new System.Drawing.Point(626, 142);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(107, 41);
			this.btnStart.TabIndex = 7;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(22, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(212, 32);
			this.label2.TabIndex = 8;
			this.label2.Text = "Path:";
			// 
			// txtPath
			// 
			this.txtPath.Enabled = false;
			this.txtPath.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txtPath.Location = new System.Drawing.Point(93, 15);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(513, 41);
			this.txtPath.TabIndex = 9;
			// 
			// btnStop
			// 
			this.btnStop.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnStop.Location = new System.Drawing.Point(626, 202);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(107, 41);
			this.btnStop.TabIndex = 11;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.BtnStopClick);
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnClear.Location = new System.Drawing.Point(626, 504);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(107, 41);
			this.btnClear.TabIndex = 12;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// labExample
			// 
			this.labExample.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.labExample.Location = new System.Drawing.Point(534, 117);
			this.labExample.Name = "labExample";
			this.labExample.Size = new System.Drawing.Size(72, 22);
			this.labExample.TabIndex = 13;
			this.labExample.Text = "Example";
			this.labExample.Click += new System.EventHandler(this.LabExampleClick);
			// 
			// ScriptForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(754, 697);
			this.Controls.Add(this.labExample);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.comInterval);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtMsg);
			this.Controls.Add(this.listBox);
			this.Controls.Add(this.btnLoad);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ScriptForm";
			this.Text = "Script";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScriptFormFormClosing);
			this.Load += new System.EventHandler(this.ScriptFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
