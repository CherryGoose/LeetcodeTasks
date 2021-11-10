using System;
using System.Collections.Generic;
using System.Globalization;

namespace LeetCode_Biggest_time
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 0, 0, 0 };
            string arrayStr = "";

            Dictionary <string,string> ListS = new Dictionary<string,string>();
            foreach (int i in arr)
            {
                arrayStr += i.ToString();
            }

            permute(arrayStr, 0, arr.Length - 1, ListS);

            DateTime dt = new DateTime();
            DateTime x = new DateTime()
;          foreach (KeyValuePair<string, string> kvp in ListS)
            {
                string key = "";
                key= kvp.Key.ToString();

                key =key.Insert(2, ":");
                DateTime.TryParse(key, out x);
                if (DateTime.Compare(dt, x)<0)
                    {
                    dt = x;
                }
            }
            if (dt == DateTime.MinValue)
            {
                // return "";
            }
            else
            {
               
                Console.WriteLine(dt.ToString("HH:mm"));
            }
            Console.ReadLine();

        }


        public static void permute(String str, int l, int r, Dictionary<string, string> ListSTR)
        {
            for (int i = l; i <= r; i++)
            {
                str = swap(str, l, i);
                permute(str, l + 1, r, ListSTR);
                str = swap(str, l, i);
                if (!ListSTR.ContainsKey(str))
                {
                    ListSTR.Add(str, str);
                }
            }



        }

        public static string swap(String a,  int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
