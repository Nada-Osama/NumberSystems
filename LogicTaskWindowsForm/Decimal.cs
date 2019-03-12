using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTaskWindowsForm
{
    class Decimal
    {
        public string DecToBin(int dec)
        {
            string binReversed = "", Bin = "";
            while (dec != 0)
            {
                if (dec % 2 == 0)
                    binReversed += "0";
                else
                    binReversed += "1";
                dec /= 2;
            }
            for (int i = binReversed.Length - 1; i >= 0; --i)
                Bin += binReversed[i];
            return Bin;
        }

        public string DecToOct(int dec)
        {
            string octReversed = "", oct = "";
            while (dec != 0)
            {
                octReversed += (dec % 8);
                dec /= 8;
            }
            for (int i = octReversed.Length - 1; i >= 0; --i)
                oct += octReversed[i];
            return oct;
        }

        public string DecToHex(int dec)
        {
            int quotient;
            string hexReversed = "", hex = "";
            while (dec != 0)
            {
                quotient = dec % 16;
                switch (quotient)
                {
                    case 10:
                        hexReversed += "A";
                        break;
                    case 11:
                        hexReversed += "B";
                        break;
                    case 12:
                        hexReversed += "c";
                        break;
                    case 13:
                        hexReversed += "D";
                        break;
                    case 14:
                        hexReversed += "E";
                        break;
                    case 15:
                        hexReversed += "F";
                        break;
                    default:
                        hexReversed += quotient;
                        break;
                }
                dec /= 16;
            }
            for (int i = hexReversed.Length - 1; i >= 0; --i)
                hex += hexReversed[i];
            return hex;
        }
    }
}
