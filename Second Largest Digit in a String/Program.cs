using System;
using System.Collections.Generic;

namespace Second_Largest_Digit_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SecondHighest("8344"));

        }


        public static int SecondHighest(string s)
        {

            int result=-1;
            int temp=-1;
            foreach(char v in s)
            {
                var tp=0;
                try
                {
                    tp = Int32.Parse(v.ToString());
                    if (result < tp)
                    {
                        temp = result;
                        result = tp;
                    }
                    if (temp < tp && tp < result)
                    {
                        temp = tp;
                    }
                }
                catch { }
            }
            return temp;
        }
    }
}
