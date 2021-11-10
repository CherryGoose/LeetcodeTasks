using System;

namespace Final_Value_of_Variable_After_Performing_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int FinalValueAfterOperations(string[] operations)
        {

            int result = 0;
            foreach (string op in operations)
            {
                if (op.Contains("+"))
                {
                    result++;
                }
                else if (op.Contains("-"))
                {
                    result--;
                }
            }
            return result;
        }
    }
}
