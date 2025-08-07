using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileComparerApp.Service
{

    public  class ByteComparer
    {
        //To compare two strings byte-by-byte to handle large lines more precisely
        public static bool AreLinesIdentical(string line1, string line2)
        {
            var bytes1 = Encoding.UTF8.GetBytes(line1);
            var bytes2 = Encoding.UTF8.GetBytes(line2);

            if (bytes1.Length != bytes2.Length)
                return false;

            for (int i = 0; i < bytes1.Length; i++)
            {
                if (bytes1[i] != bytes2[i])
                    return false;
            }

            return true;
        }
    }
}
