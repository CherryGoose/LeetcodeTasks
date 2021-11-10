using System;
using System.Collections;

namespace HasAlternatingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HasAlternatingBits(1));
        }


        public static bool HasAlternatingBits(int n)
        {
            string b = Convert.ToString(n,2);
            bool result=false;
            for (int i = 0; i < b.Length; i++)
            {
                if (i + 1 < b.Length)
                {
                    if (b[i] != b[i + 1])
                    {
                        result = true;
                    }
                    else {
                        result = false;
                        break;
                    }
                }
                 
            }
            if (b == "1")
            {
                result= true;
            }
            return result;
        }
    }
}
