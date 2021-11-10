using System;
using System.Collections.Generic;

namespace Math_Homework
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> points = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine(minNum(5, points));

        }


        public static int minNum(int threshold, List<int> points)
        {
            int minPoints = points[0];
            int problemsCount = 1;
            bool solutionfound = false;

            for (int i = 1; i < points.Count; i++)
            {
                if (points[i] - minPoints >= threshold)
                {
                    solutionfound = true;
                    problemsCount++;    
                    break;
                }
                else
                {
                        if (i+1 < points.Count && points[i + 1] - minPoints >= threshold)
                        {
                            solutionfound = true;
                            problemsCount++;
                            break;
                        }
                        else if (i + 2 < points.Count && points[i + 2] - minPoints >= threshold)
                        {
                            solutionfound = true;
                            problemsCount++;
                            break;
                        }
                        else
                        {
                            problemsCount++;
                        }
                    
                }


            }
            if (!solutionfound)
            {
                return points.Count;
            }
            else {
                return problemsCount;   
            }
        }
    }
}
