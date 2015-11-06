using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Storage.Streams;

namespace QuanLyThuChi.Util
{
    public class EncryptPassword
    {
        public string encrypt(string text)
        {
            string base64Encoded = string.Empty;

            IBuffer buffer = CryptographicBuffer.ConvertStringToBinary(text, BinaryStringEncoding.Utf8);

            HashAlgorithmProvider provider = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Sha1);

            //hash it

            IBuffer hash = provider.HashData(buffer);

            base64Encoded = CryptographicBuffer.EncodeToBase64String(hash);

            return base64Encoded;
        }
    }
}
