using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTaskWindowsForm
{
    class Binary
    {
        public int BinToDec(string bin)
        {
            int dec = 0;
            char[] binArray = bin.ToCharArray();
            Array.Reverse(binArray);
            for (int i = 0; i < binArray.Length; ++i)
            {
                if (binArray[i] == '1')
                    dec += (int)Math.Pow(2, i);
            }
            return dec;
        }

        public string BinToOct(string bin)
        {
            int itsDec = Convert.ToInt32(bin, 2);
            return Convert.ToString(itsDec, 8);
        }

        public string BinToHex (string bin)
        {
            return Convert.ToInt32(bin, 2).ToString("x");
        }
    }
}
