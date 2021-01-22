using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareRegister.Utility
{
	public static class DESHelper
	{
		private const UInt32 m_delta = 0x9E3779B9;
		private const string m_key = "1234567890abcdef";
		private static readonly Encoding m_encoding = Encoding.UTF8;

		#region Common

		private static UInt32[] ChangeKey(UInt32[] key)
		{
			UInt32[] k = new UInt32[4];
			key.CopyTo(k, 0);

			return k;
		}

		private static byte[] ToByteArray(UInt32[] datas, bool includeLength)
		{
			Int32 length = includeLength ? (Int32)datas[datas.Length - 1] : datas.Length << 2;

			byte[] results = new byte[length];
			for (Int32 i = 0; i < length; i++)
			{
				results[i] = (byte)(datas[i >> 2] >> ((i & 3) << 3));
			}

			return results;
		}

		private static UInt32[] ToUInt32Array(byte[] datas, bool includeLength)
		{
			Int32 length = ((0 == (datas.Length & 3)) ? (datas.Length >> 2) : ((datas.Length >> 2) + 1));

			UInt32[] results = includeLength ? CreateUInt32IncludeLength(length, datas.Length) : new UInt32[length];

			for (int i = 0; i < datas.Length; i++)
			{
				results[i >> 2] |= (UInt32)datas[i] << ((i & 3) << 3);
			}

			return results;
		}

		private static UInt32[] CreateUInt32IncludeLength(int length, int dataslength)
		{
			UInt32[] results = new UInt32[length + 1];
			results[length] = (UInt32)dataslength;

			return results;
		}

		#endregion


		#region Hash

		/// <summary>
		///     加密字符串
		/// </summary>
		/// <param name="target">需要加密的字符串</param>
		/// <param name="key">加密用的Key值</param>
		/// <returns>加密后的字符串</returns>
		public static string Encrypt(string target, string key = m_key)
		{
			byte[] datas = Encrypt(m_encoding.GetBytes(target), m_encoding.GetBytes(key));

			return Convert.ToBase64String(datas);
		}

		private static byte[] Encrypt(byte[] datas, byte[] keys)
		{
			return 0 == datas.Length ? datas : ToByteArray(Encrypt(ToUInt32Array(datas, true), ToUInt32Array(keys, false)), false);
		}

		private static UInt32[] Encrypt(UInt32[] value, UInt32[] key)
		{
			Int32 length = value.Length - 1;

			if (length < 1) return value;

			if (key.Length < 4)
			{
				key = ChangeKey(key);
			}

			UInt32 z = value[length];
			UInt32 sum = 0;
			Int32 q = 6 + 52 / (length + 1);

			while (q-- > 0)
			{
				sum = unchecked(sum + m_delta);
				var e = sum >> 2 & 3;
				Int32 p;
				UInt32 y;
				for (p = 0; p < length; p++)
				{
					y = value[p + 1];
					z = unchecked(value[p] += (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (key[p & 3 ^ e] ^ z));
				}
				y = value[0];
				z =
					unchecked(value[length] += (z >> 5 ^ y << 2) + (y >> 3 ^ z << 4) ^ (sum ^ y) + (key[p & 3 ^ e] ^ z)
						);
			}

			return value;
		}

		#endregion Hash


		#region Encode/Decode

		private static readonly string KEY_64 = "";
		private static readonly string IV_64 = "";

		public static string Encode(string data)
		{
			byte[] byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(KEY_64);
			byte[] byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV_64);

			DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
			int i = cryptoProvider.KeySize;
			MemoryStream ms = new MemoryStream();
			CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateEncryptor(byKey, byIV), CryptoStreamMode.Write);

			StreamWriter sw = new StreamWriter(cst);
			sw.Write(data);
			sw.Flush();
			cst.FlushFinalBlock();
			sw.Flush();
			return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);

		}

		public static string Decode(string data)
		{
			byte[] byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(KEY_64);
			byte[] byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV_64);

			byte[] byEnc;
			try
			{
				byEnc = Convert.FromBase64String(data);
			}
			catch
			{
				return null;
			}

			DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
			MemoryStream ms = new MemoryStream(byEnc);
			CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateDecryptor(byKey, byIV), CryptoStreamMode.Read);
			StreamReader sr = new StreamReader(cst);
			return sr.ReadToEnd();
		}

		#endregion Encode/Decode

		#region DesEncrypt

		private static string DesKey = "2020Cast";//密钥,要求为8位

		//默认密钥向量
		//private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
		private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

		/// <summary>
		/// DES加密字符串
		/// </summary>
		/// <param name="encryptString">待加密的字符串</param>
		/// <param name="encryptKey">加密密钥,要求为8位</param>
		/// <returns>加密成功返回加密后的字符串，失败返回源串</returns>
		public static string EncryptDES(string encryptString)
		{
			try
			{
				byte[] rgbKey = Encoding.UTF8.GetBytes(DesKey.Substring(0, 8));
				byte[] rgbIV = Keys;
				byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
				DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
				MemoryStream mStream = new MemoryStream();
				CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
				cStream.Write(inputByteArray, 0, inputByteArray.Length);
				cStream.FlushFinalBlock();
				return Convert.ToBase64String(mStream.ToArray());
			}
			catch
			{
				return "";
			}
		}

		/// <summary>
		/// DES解密字符串
		/// </summary>
		/// <param name="decryptString">待解密的字符串</param>
		/// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
		/// <returns>解密成功返回解密后的字符串，失败返源串</returns>
		public static string DecryptDES(string decryptString)
		{
			try
			{
				byte[] rgbKey = Encoding.UTF8.GetBytes(DesKey);
				byte[] rgbIV = Keys;
				byte[] inputByteArray = Convert.FromBase64String(decryptString);
				DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
				MemoryStream mStream = new MemoryStream();
				CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
				cStream.Write(inputByteArray, 0, inputByteArray.Length);
				cStream.FlushFinalBlock();
				return Encoding.UTF8.GetString(mStream.ToArray());
			}
			catch
			{
				return "";
			}
		}

		#endregion DesDeEncrypt
	}
}
