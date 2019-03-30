using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTaskWindowsForm
{
    class Hexdecimal
    {
        string hexToDec;
        Decimal DecObj = new Decimal();
        public string HexToDec(string hex)
        {
            int dec = 0, charToNumber;
            char[] hexArray = hex.ToCharArray();
            Array.Reverse(hexArray);
            for (int i = 0; i < hexArray.Length; ++i)
            {
                switch (hexArray[i].ToString().ToUpper())
                {
                    case "A":
                        charToNumber = 10;
                        break;
                    case "B":
                        charToNumber = 11;
                        break;
                    case "C":
                        charToNumber = 12;
                        break;
                    case "D":
                        charToNumber = 13;
                        break;
                    case "E":
                        charToNumber = 14;
                        break;
                    case "F":
                        charToNumber = 15;
                        break;
                    default:
                        charToNumber = int.Parse(hexArray[i].ToString());
                        break;
                }
                dec += (int)Math.Pow(16, i) * charToNumber;
            }
            return dec.ToString();
        }
        public string HexToBin(string hex)
        {
            hexToDec = HexToDec(hex);
            return DecObj.DecToBin(int.Parse(hexToDec));
        }
        public string HexToOct(string hex)
        {
            hexToDec = HexToDec(hex);
            return DecObj.DecToOct(int.Parse(hexToDec));
        }
    }
}
