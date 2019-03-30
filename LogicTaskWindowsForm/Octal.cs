using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicTaskWindowsForm
{
    class Octal
    {
        string octToDec;
        Decimal DecObj = new Decimal();
        public string OctToDec(string oct)
        {
            int dec = 0, charToNumber;
            char[] octArray = oct.ToCharArray();
            Array.Reverse(octArray);
            for (int i = 0; i < octArray.Length; ++i)
            {
                charToNumber = int.Parse(octArray[i].ToString());
                dec += (int)Math.Pow(8, i) * charToNumber;
            }
            return dec.ToString();
        }
        public string OctToBin(string oct)
        {
            octToDec = OctToDec(oct);
            return DecObj.DecToBin(int.Parse(octToDec));
        }
        public string OctToHex(string oct)
        {
            octToDec = OctToDec(oct);
            return DecObj.DecToHex(int.Parse(octToDec));
        }
    }
}
