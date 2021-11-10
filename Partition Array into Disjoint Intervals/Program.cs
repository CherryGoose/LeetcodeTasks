using System;

namespace Partition_Array_into_Disjoint_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 26, 51, 40, 58, 42, 76, 30, 48, 79, 91 }; //1
            //90, 47, 69, 10, 43, 92, 31, 73, 61, 97  /9
            //  26, 51, 40, 58, 42, 76, 30, 48, 79, 91  /1
            // [5,0,3,8,6]  // 3
            //[1,1,1,0,6,12] // 4 
            
            Console.WriteLine(PartitionDisjoint(nums));
        }

        public static int PartitionDisjoint(int[] nums)
        {
            int currMax = nums[0];
            int possibleMax = nums[0];
            int length = 1;

            for (int i = 1; i < nums.Length; ++i)
            {
                if (nums[i] < currMax)
                {
                    length = i + 1;
                    currMax = possibleMax;
                }
                else
                {
                    possibleMax = Math.Max(possibleMax, nums[i]);
                }
            }

            return length;
        }
    }
}
