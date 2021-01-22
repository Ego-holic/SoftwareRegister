using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareRegister.Utility
{
	class WaitDialog
	{
		private static DevExpress.Utils.WaitDialogForm wdf = null;
		public static void SetCaption(string caption, string title, System.Drawing.Size nSize)
		{
			wdf = new DevExpress.Utils.WaitDialogForm(caption, title, nSize);
		}
		public static void SetCaption(string caption)
		{
			if (wdf == null)
				wdf = new DevExpress.Utils.WaitDialogForm(caption, "请稍等", new System.Drawing.Size(400, 100));
			else
				wdf.SetCaption(caption);
		}

		public static void CancelWDF()
		{
			if (wdf != null)
			{
				wdf.Close();
				wdf.Dispose();
				wdf = null;
			}
		}
	}
}
