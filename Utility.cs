using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CovidAirlines
{
    public class Utility
    {
        public static byte[] GenerateHash(string pass)
        {
            using (SHA512 shaM = new SHA512Managed())
            {
                return shaM.ComputeHash(Encoding.UTF8.GetBytes(pass));
            }
        }
    }
}
