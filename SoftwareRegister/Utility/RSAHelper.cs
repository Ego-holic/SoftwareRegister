using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareRegister.Utility
{
	public class RSAHelper
	{
		private static string public_Key { get; set; }
		private static string private_Key { get; set; }
		/// <summary>
		/// 获取公钥和私钥
		/// </summary>
		/// <returns></returns>
		private static void GetKeyPair()
		{
			RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
			public_Key = RSA.ToXmlString(false);
			private_Key = RSA.ToXmlString(true);
		}

		/// <summary>
		/// RSA加密
		/// </summary>
		/// <param name="str">待加密的字符串</param>
		/// <returns></returns>
		public static string RSAEncrypt(string str)
		{
			GetKeyPair();
			if (string.IsNullOrEmpty(public_Key) || string.IsNullOrEmpty(str))
				return null;
			RSACryptoServiceProvider provider = new RSACryptoServiceProvider();
			provider.FromXmlString(public_Key);
			byte[] bytes = new UnicodeEncoding().GetBytes(str);
			return BitConverter.ToString(provider.Encrypt(bytes, RSAEncryptionPadding.Pkcs1));

		}
		/// <summary>
		/// RSA解密
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string RSADecrypt(string str)
		{
			if (string.IsNullOrEmpty(private_Key) || string.IsNullOrEmpty(str))
				return null;
			RSACryptoServiceProvider provider = new RSACryptoServiceProvider();
			provider.FromXmlString(private_Key);
			byte[] rgb = Convert.FromBase64String(str);
			byte[] bytes = provider.Decrypt(rgb, RSAEncryptionPadding.OaepSHA1);
			return new UnicodeEncoding().GetString(bytes);
		}
	}
}
