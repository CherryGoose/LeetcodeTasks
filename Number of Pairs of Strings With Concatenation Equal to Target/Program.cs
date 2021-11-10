using System;

namespace Number_of_Pairs_of_Strings_With_Concatenation_Equal_to_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = new string[] { "777", "7", "77", "77" };
            string target = "7777";
            Console.WriteLine(NumOfPairs(input,target));
        }


        public static int NumOfPairs(string[] nums, string target)
        {
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        if (nums[i] + nums[j] == target)
                        {

                            result++;
                         
                        }
                    }
                }
            }


            return result;
        }
    }
}
