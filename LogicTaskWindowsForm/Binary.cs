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

        /// <summary>
        /// Edit the specified <paramref name="binary"/> by adding
        /// to it some leading zeors to make its length divisible
        /// by <paramref name="numberOfBits"/>
        /// </summary>
        /// <param name="binary">The specified binary number</param>
        /// <param name="numberOfBits">The number of bits to make the binary
        /// number length divisible by it</param>
        private string editBinary(string binary, int numberOfBits)
        {
            if (binary.Length % numberOfBits != 0)
            {
                int leadingZeros = numberOfBits - (binary.Length % numberOfBits);
                string zeros = "";
                for (int i = 0; i < leadingZeros; i++)
                    zeros += "0";
                binary = zeros + binary;
            }
            return binary;
        }
        
        public string BinToOct(string bin)
        {
            // TODO Binary to Octal was edited
            string octal = "";
            bin = editBinary(bin, 3); // See Line 32
            for (int i = bin.Length - 1; i >= 0; )
            {
                double right3Bits = 0;
                for (int j = 0; j < 3; j++, i--)
                    right3Bits += Math.Pow(2, j) * (bin[i] - '0');
                octal = right3Bits.ToString() + octal;
            }
            return octal;








            //int itsDec = Convert.ToInt32(bin, 2);
            //return Convert.ToString(itsDec, 8);

            
            //int bit, binNumber;
            //string threeBits = "", oct = "", octReversed = "";

            //// بتحولى الباينرى لانتجر ... طب يرضى مين ده ؟
            ////binNumber = int.Parse(bin);

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
            // TODO Binary to Hexadecimal was edited
            string hexadecimal = "";
            bin = editBinary(bin, 4); // See Line 32
            for (int i = bin.Length - 1; i >= 0;)
            {
                double right4Bits = 0;
                for (int j = 0; j < 4; j++, i--)
                    right4Bits += Math.Pow(2, j) * (bin[i] - '0');

                // Note : The Unicode of char 'A' is 65 which equal = 10 + 55.
                if (right4Bits > 9) hexadecimal = (char)(right4Bits + 55) + hexadecimal;
                else hexadecimal = right4Bits.ToString() + hexadecimal;
            }
            return hexadecimal;








            //return Convert.ToInt32(bin, 2).ToString("x");
            
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
