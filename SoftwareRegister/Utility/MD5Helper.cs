using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareRegister.Utility
{
	public class MD5Helper
	{
		/// <summary>
		/// 64位MD5加密
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string MD5EncryptString(string str)
		{
			if (string.IsNullOrEmpty(str))
				return null;
			MD5 md5 = MD5.Create();
			byte[] byteArr = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
			// 返回加密的字符串
			return BitConverter.ToString(byteArr);
		}
	}
}
