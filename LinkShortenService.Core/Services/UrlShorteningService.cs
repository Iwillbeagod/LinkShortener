using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkShortenService.Core.Services
{
    public static class UrlShorteningService
    {
        private static string _urlDomain
        {
            get
            {
                return ConfigurationManager.AppSettings["UrlDomain"];
            }
        }

        private static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static string GetShortenUrl(string originUrl)
        {
            var timeStamp = DateTime.UtcNow.Ticks;
            var source = originUrl + timeStamp.ToString();

            var hashUrl = CreateMD5(source);

            return _urlDomain + hashUrl;
        }
    }
}
