using System;

namespace Number_of_Matching_Subsequences
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "abcde";// s = "abcde", words = ["a", "bb", "acd", "ace"]
            string [] words = { "a", "bb", "acd", "ace" };
            Console.WriteLine(NumMatchingSubseq(input,words));
        }


        public static int NumMatchingSubseq(string s, string[] words)
        {
            int result = 0;
            foreach(string word in words)
            {
                int counter = 0;
                int pos = 0;
                for (int i = 0; i < word.Length; i++)
                {
                    while (pos != s.Length)
                    {
                        if (word[i] == s[pos])
                        {
                            counter++;
                            pos++;
                            break;
                        }
                        pos++;
                    }
                }
                if (counter == word.Length)
                { result++; }
            }

            return result;
        }
    }
}
