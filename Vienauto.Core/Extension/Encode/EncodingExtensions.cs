using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Vienauto.Core.Extension.Encode
{
    public static class EncodingExtensions
    {
        public static string EncodeMD5(string value)
        {
            var encodedString = string.Empty;
            byte[] arrValues = System.Text.Encoding.UTF8.GetBytes(value);
            MD5CryptoServiceProvider md5EncodeProvider = new MD5CryptoServiceProvider();
            arrValues = md5EncodeProvider.ComputeHash(arrValues);

            foreach (byte item in arrValues)
                encodedString += item.ToString("X2");

            return encodedString;
        }
    }
}
