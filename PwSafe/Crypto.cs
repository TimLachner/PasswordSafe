using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Security;
using System.Windows.Forms;
using System.Runtime;
using System.IO;

namespace PwSafe
{
    class Crypto
    {

        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static int seedgen()
        {
            var directoryInfo = new System.IO.DirectoryInfo(@"c:/");

            string name = Environment.UserName;
            Random r = new Random();
            int a = r.Next(-999999999, 999999999);
            int b = Environment.TickCount & Int32.MaxValue;
            int c = name.Length;
            int d = directoryInfo.GetDirectories().Length;
            //int e = Convert.ToInt32(DateTime.Now.Ticks);
            //int  = Convert.ToInt32(System.Windows.Forms.Control.MousePosition);
            int seedf = a * b * c * d;
            return seedf;

        }
        public static string randompw(int length, bool uppercase, bool specialchar)
        {
            string valid = "abcdefghijklmnopqrstuvwxyz1234567890";
            if (specialchar)
            {
                valid = "abcdefghijklmnopqrstuvwxyz1234567890%$§!&/()=?*+-><.,_°^*~#";
            }
            if (uppercase)
            {
                valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            }
            if (specialchar && uppercase)
            {
                valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890%$§!&/()=?*+-><.,_°^*~#";
            }
            StringBuilder res = new StringBuilder();
            Random rnd = new Random(seedgen());


            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        public static string randomCode()
        {
            string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int length = 5;
            StringBuilder res = new StringBuilder();
            Random rnd = new Random(seedgen());
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}
