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

            //int bit, binNumber;
            //string threeBits = "", oct = "", octReversed = "";
            //binNumber = int.Parse(bin);
            //while (binNumber != 0)
            //{
            //    bit = binNumber % 10;
            //    threeBits += bit;
            //    if ((threeBits.Length % 3 == 0 && threeBits != "0"))
            //    {
            //        oct += BinToDec(threeBits);
            //        threeBits = "";
            //    }
            //    if (binNumber == 10 || binNumber == 01 || binNumber == 11 || binNumber == 1)
            //    {
            //        threeBits = binNumber.ToString();
            //        oct += BinToDec(threeBits);
            //        binNumber = 0;
            //    }
            //    binNumber /= 10;
            //}
            //for (int i = oct.Length - 1; i >= 0; --i)
            //    octReversed += oct[i];
            //return octReversed;
        }

        public string BinToHex (string bin)
        {
            return Convert.ToInt32(bin, 2).ToString("x");

            //int bit, binNumber;
            //string fourBits = "", hex = "", hexReversed = "";
            //binNumber = int.Parse(bin);
            //while (binNumber != 0)
            //{
            //    bit = binNumber % 10;
            //    fourBits += bit;
            //    if ((fourBits.Length % 4 == 0 && fourBits != "0"))
            //    {
            //        hex += BinToDec(fourBits);
            //        fourBits = "";
            //    }
            //    if (binNumber == 10 || binNumber == 01 || binNumber == 11 || binNumber == 1)
            //    {
            //        binNumber /= 10;
            //        fourBits = binNumber.ToString();
            //        hex += BinToDec(fourBits);
            //        binNumber = 0;
            //    }
            //    binNumber /= 10;
            //}
            //for (int i = hex.Length - 1; i >= 0; --i)
            //    hexReversed += hex[i];
            //return hexReversed;
        }
    }
}
