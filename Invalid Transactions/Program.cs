using System;
using System.Collections.Generic;
using System.Linq;

namespace Invalid_Transactions
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] input = {"alex,676,260,bangkok","bob,656,1366,bangkok","alex,393,616,bangkok","bob,820,990,amsterdam","alex,596,1390,amsterdam" };

            Console.WriteLine(InvalidTransactions(input));
        }

        public static IList<string> InvalidTransactions(string[] transactions)
        {
            int[] removeList = new int[transactions.Length];
          
            for (int i = 0; i < transactions.Length; i++)
            {
                string[] transactionOne = transactions[i].Split(',');
                if (Int32.Parse(transactionOne[2]) > 1000)
                {
                    {
                        removeList[i] = 1;
                        continue;
                    }
                }
                for (int j = 0; j < transactions.Length; j++)
                {
                    if (i != j)
                    {
                        if (transactions[i] == transactions[j])
                        {
                            removeList[i] = 1;
                            continue;
                        }
                        string[] transactionTwo = transactions[j].Split(',');
                        if (transactionOne[0] == transactionTwo[0] &&
                            (Math.Abs(Int32.Parse(transactionTwo[1]) - Int32.Parse(transactionOne[1])) <= 60) && transactionOne[3] != transactionTwo[3])
                        {
                                removeList[i] = 1;
                        }
                    }
                }

            }

            List<string> result = new List<string>();
            for (int i = 0; i < transactions.Length; i++)
            {
                if (removeList[i] == 1)
                {
                    result.Add(transactions[i]);
                }
            }

            return result;
        }
    }
}
