using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Management;
using System.Security.Cryptography;
using SoftwareRegister.Utility;

namespace SoftwareRegister
{
	public partial class MainForm : DevExpress.XtraEditors.XtraForm
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			this.teSerialNum.Text = GetMD5SoftwareSerialNum();
		}

		private string GetMD5SoftwareSerialNum()
		{
			try
			{

				string serialStr = string.Empty;

				//CPU序列号
				ManagementClass cpuMc = new ManagementClass("Win32_Processor");
				ManagementObjectCollection cpuMoc = cpuMc.GetInstances();
				foreach (ManagementObject mo in cpuMoc)
				{
					serialStr += mo.Properties["ProcessorId"].Value.ToString();
				}

				//硬盘序列号
				ManagementClass diskMc = new ManagementClass("Win32_DiskDrive");
				ManagementObjectCollection diskMoc = diskMc.GetInstances();
				foreach (ManagementObject mo in diskMoc)
				{
					serialStr += mo.Properties["SerialNumber"].Value.ToString();
				}
				return MD5Helper.MD5EncryptString(serialStr);
			}
			catch(Exception ex)
			{
				UcMessageBox.ShowError("软件序列号生成失败！");
				return null;
			}
		}

		private void sbSerialNum_Click(object sender, EventArgs e)
		{
			this.teSerialNum.Text = GetMD5SoftwareSerialNum();
		}

		private void sbCancel_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Dispose();
		}

		private void sbActiveNum_Click(object sender, EventArgs e)
		{
			try
			{
				WaitDialog.SetCaption("正在生成【激活码】！请稍候...");
				if (string.IsNullOrEmpty(teSerialNum.Text))
				{
					UcMessageBox.ShowInfo("请填写【软件序列号】！");
					return;
				}
				meActiveNum.Text = $"{DESHelper.EncryptDES(teSerialNum.Text.Replace("-",""))}";
			}catch(Exception ex)
			{
				UcMessageBox.ShowError("【软件激活码】生成失败！");
				return;
			}
			finally
			{
				WaitDialog.CancelWDF();
			}

		}
	}
}