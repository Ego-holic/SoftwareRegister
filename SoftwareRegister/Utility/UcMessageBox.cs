using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareRegister.Utility
{
	public class UcMessageBox
	{
		/// <summary>
		/// 操作提示，圈圈+小写I组成
		/// </summary>
		/// <param name="strInfo"></param>
		public static void ShowInfo(string strInfo)
		{
			WaitDialog.CancelWDF();
			XtraMessageBox.Show(strInfo, "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
		}
		/// <summary>
		/// 操作Asterisk,操作提示，圈圈+小写I组成
		/// </summary>
		/// <param name="strInfo"></param>
		public static void ShowAsterisk(string strInfo)
		{
			WaitDialog.CancelWDF();
			XtraMessageBox.Show(strInfo, "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
		}
		/// <summary>
		/// 操作警告，黄色三角形+感叹号
		/// </summary>
		/// <param name="strInfo"></param>
		public static void ShowWarning(string strInfo)
		{
			WaitDialog.CancelWDF();
			XtraMessageBox.Show(strInfo, "操作警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
		}
		/// <summary>
		/// 操作警告，黄色三角形+感叹号
		/// </summary>
		/// <param name="strInfo"></param>
		public static void ShowExclamation(string strInfo)
		{
			WaitDialog.CancelWDF();
			XtraMessageBox.Show(strInfo, "操作警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
		}
		/// <summary>
		/// 操作Hand,不可操作，背景是红色圈圈+黄色X
		/// </summary>
		/// <param name="strInfo"></param>
		public static void ShowHand(string strInfo)
		{
			WaitDialog.CancelWDF();
			XtraMessageBox.Show(strInfo, "不可操作", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
		}
		/// <summary>
		/// 操作Hand,错误，背景是红色圈圈+黄色X
		/// </summary>
		/// <param name="strInfo"></param>
		public static void ShowError(string strInfo)
		{
			WaitDialog.CancelWDF();
			XtraMessageBox.Show(strInfo, "操作错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
		}
		/// <summary>
		/// 操作提示,没有符号
		/// </summary>
		/// <param name="strInfo"></param>
		public static void ShowNone(string strInfo)
		{
			WaitDialog.CancelWDF();
			XtraMessageBox.Show(strInfo, "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
		}
		/// <summary>
		/// 操作提示,不可操作，背景是红色圈圈+白色X
		/// </summary>
		/// <param name="strInfo"></param>
		public static void ShowStop(string strInfo)
		{
			WaitDialog.CancelWDF();
			XtraMessageBox.Show(strInfo, "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
		}

		/// <summary>
		/// 操作询问
		/// </summary>
		/// <param name="strInfo"></param>
		public static DialogResult ShowQuestionYesNo(string strInfo)
		{
			WaitDialog.CancelWDF();
			return XtraMessageBox.Show(strInfo, "操作询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}
		/// <summary>
		/// 操作询问
		/// </summary>
		/// <param name="strInfo"></param>
		public static DialogResult ShowQuestionYesNoCancel(string strInfo)
		{
			WaitDialog.CancelWDF();
			return XtraMessageBox.Show(strInfo, "操作询问", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
		}
	}
}
