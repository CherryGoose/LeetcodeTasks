using System;
using System.Collections;
using System.Linq;
using System.Numerics;

namespace Add_Binary
{
    class Program
    {
        static void Main(string[] args)
        {

            string one = "1010";
            string two = "1011";
            //"11101011111011011001001101111101010000100100110010001000000000010111111010000110001110000011110010"
            Console.WriteLine(AddBinary(one, two));

        }
        public static string AddBinary(string a, string b)
        {
            string leadingStr=""; //"1010"
           
            string secondStr="";   // "1011"

            if (a.Length >= b.Length)
            {
                leadingStr = a;
                secondStr = b;
            }
            else 
            {
                leadingStr = b;
                secondStr = a;
            }

            while (secondStr.Length != leadingStr.Length)
            {
                secondStr = "0" + secondStr;
            }

            string Result ="";

            bool carryOne = false;
            for(int i = leadingStr.Length-1; i>=0; i--)
            {
                if (carryOne && leadingStr[i] == '1' && secondStr[i] == '1') 
                {
                    Result = "1"+ Result;
                    continue;
                }
                if (carryOne && (leadingStr[i] == '1' || secondStr[i] == '1'))
                {
                    Result = "0" + Result;
                    continue;
                }
                if (carryOne && (leadingStr[i] == '0' || secondStr[i] == '0'))
                {
                    carryOne = false;
                    Result = "1" + Result;
                    continue;
                }
                if (leadingStr[i] == '1' && secondStr[i] == '1'&&!carryOne)
                {
                    carryOne = true;
                    Result = "0" + Result;
                    continue;
                }
                if(!carryOne && leadingStr[i] == '0' && secondStr[i] == '0')
                {
                    Result = "0" + Result;
                    continue;
                }
                if (!carryOne && (leadingStr[i] == '0' || secondStr[i] == '0'))
                {
                    Result = "1" + Result;
                    continue;
                }
            }
            if (carryOne)
            {
                Result = "1" + Result;
            }

            return Result;
        }
    }
}
