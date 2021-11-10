using System;
using System.Collections;
using System.Linq;

namespace mallest_Rotation_with_Highest_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 2, 3, 1, 4, 0 };
           Console.WriteLine( BestRotation(input));
        }

        public static int BestRotation(int[] nums)
        {
            int result = 0;
            int maxScore=0;
            for (int i = 0; i < nums.Length; i++)
            {
                int tempScore = 0;
                int counter=0;
                for (int j=0;j<nums.Length;j++)
                {
                    if (nums[j]<= counter)
                    {
                        tempScore++;
                    }
                    counter++;
                }
                if (tempScore > maxScore)
                {
                    result = i;
                    maxScore = tempScore;
                }
                RorateArray(ref nums);
            }
           

            return result;
        }

        public static void RorateArray(ref int [] input)
        {
            int firstnum = input[0];
            int [] temp = new int[input.Length];
            for (int i = 0; i < input.Length - 1; i++)
            {
                temp[i] = input[i + 1];
            }
            temp[temp.Length-1] = firstnum;
            input = temp;

        }
    }
}
