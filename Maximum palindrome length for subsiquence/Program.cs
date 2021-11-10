using System;
using System.Collections.Generic;

namespace Maximum_palindrome_length_for_subsiquence
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = "cacb";
            string word2 = "cbba";
                            //abbc

            Console.WriteLine(LongestPalindrome(word1, word2));
        }



        public static int LongestPalindrome(string word1, string word2)
        {
            int result = 0;
            char[] array = word2.ToCharArray();
            Array.Reverse(array);
            string flippedString = new string (array);

            int counter = 0;
            int savedIndex = 0;


            for (int i = 0; i < word1.Length; i++)
            {
                
                for (int j = savedIndex; j < word2.Length; j++)
                {
                    if (i <= j)
                    {
                        if (word1[i] == word2[j])
                        {
                            counter++;
                            break;
                        }
                    }
                }
            }

            return result;
        }
    }
}
