using System;

namespace TwonumRedux
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( findMaxNum(7,3,0));
        }
        public static int findMaxNum(int x, int y, int z)
        {
            int max = 0;
            if (x == 0 && y == 0 && z == 0)
            { return 0; }
            if (x != 0 && y != 0 && z == 0)
            { return -1; }
            if (x > y)
            {
                if (x - z == y)
                {
                    max = x;
                }
                else if (x - z < y)
                {
                    if (z % 2 == 0)
                    {
                        max = -1;
                    }
                    else
                    {
                        max = x;
                    }
                }
            }
            else if (x < y)
            {
                if (x + z == y)
                {
                    max = x;
                }
                else if (x + z > y)
                {
                    if (z % 2 == 0)
                    {
                        max = -1;
                    }
                    else
                    {
                        max = x + (((x + z) - y) / 2);
                    }
                }
            }
            else
            if (x == y)
            {
                if (z % 2 == 0)
                {
                    max = x + z / 2;
                }
                else { max = -1; }
            }

            return max;
        }
    }
}
