namespace SoftwareRegister
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.panel2 = new System.Windows.Forms.Panel();
			this.meActiveNum = new DevExpress.XtraEditors.MemoEdit();
			this.sbCancel = new DevExpress.XtraEditors.SimpleButton();
			this.sbActiveNum = new DevExpress.XtraEditors.SimpleButton();
			this.sbSerialNum = new DevExpress.XtraEditors.SimpleButton();
			this.teSerialNum = new DevExpress.XtraEditors.TextEdit();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.meActiveNum.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.teSerialNum.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.labelControl1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(605, 100);
			this.panel1.TabIndex = 0;
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelControl1.Appearance.Font = new System.Drawing.Font("楷体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(173, 42);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(296, 35);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "航科院软件注册机";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.meActiveNum);
			this.panel2.Controls.Add(this.sbCancel);
			this.panel2.Controls.Add(this.sbActiveNum);
			this.panel2.Controls.Add(this.sbSerialNum);
			this.panel2.Controls.Add(this.teSerialNum);
			this.panel2.Controls.Add(this.labelControl3);
			this.panel2.Controls.Add(this.labelControl2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 100);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(605, 185);
			this.panel2.TabIndex = 1;
			// 
			// meActiveNum
			// 
			this.meActiveNum.Location = new System.Drawing.Point(173, 73);
			this.meActiveNum.Name = "meActiveNum";
			this.meActiveNum.Size = new System.Drawing.Size(351, 45);
			this.meActiveNum.TabIndex = 7;
			// 
			// sbCancel
			// 
			this.sbCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sbCancel.Appearance.Options.UseFont = true;
			this.sbCancel.Location = new System.Drawing.Point(449, 136);
			this.sbCancel.Name = "sbCancel";
			this.sbCancel.Size = new System.Drawing.Size(75, 37);
			this.sbCancel.TabIndex = 6;
			this.sbCancel.Text = "取消";
			this.sbCancel.Click += new System.EventHandler(this.sbCancel_Click);
			// 
			// sbActiveNum
			// 
			this.sbActiveNum.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sbActiveNum.Appearance.Options.UseFont = true;
			this.sbActiveNum.Location = new System.Drawing.Point(294, 136);
			this.sbActiveNum.Name = "sbActiveNum";
			this.sbActiveNum.Size = new System.Drawing.Size(96, 37);
			this.sbActiveNum.TabIndex = 5;
			this.sbActiveNum.Text = "生成激活码";
			this.sbActiveNum.Click += new System.EventHandler(this.sbActiveNum_Click);
			// 
			// sbSerialNum
			// 
			this.sbSerialNum.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sbSerialNum.Appearance.Options.UseFont = true;
			this.sbSerialNum.Location = new System.Drawing.Point(110, 136);
			this.sbSerialNum.Name = "sbSerialNum";
			this.sbSerialNum.Size = new System.Drawing.Size(118, 37);
			this.sbSerialNum.TabIndex = 4;
			this.sbSerialNum.Text = "生成本机序列号";
			this.sbSerialNum.Click += new System.EventHandler(this.sbSerialNum_Click);
			// 
			// teSerialNum
			// 
			this.teSerialNum.Location = new System.Drawing.Point(173, 27);
			this.teSerialNum.Name = "teSerialNum";
			this.teSerialNum.Size = new System.Drawing.Size(351, 20);
			this.teSerialNum.TabIndex = 2;
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(47, 74);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(120, 19);
			this.labelControl3.TabIndex = 1;
			this.labelControl3.Text = "软件激活码：";
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(47, 26);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(120, 19);
			this.labelControl2.TabIndex = 0;
			this.labelControl2.Text = "软件序列号：";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 285);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "软件注册机";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.meActiveNum.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.teSerialNum.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private System.Windows.Forms.Panel panel2;
		private DevExpress.XtraEditors.TextEdit teSerialNum;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.SimpleButton sbCancel;
		private DevExpress.XtraEditors.SimpleButton sbActiveNum;
		private DevExpress.XtraEditors.SimpleButton sbSerialNum;
		private DevExpress.XtraEditors.MemoEdit meActiveNum;
	}
}