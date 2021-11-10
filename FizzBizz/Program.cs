using System;

namespace FizzBizz
{
    class Program
    {
        static void Main(string[] args)
        {

            fizzBuzz(15);

        }
        

        public static void fizzBuzz(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("FizzBizz");
            }
            else if (n % 3 == 0 && n % 5 != 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (n % 5 == 0 && n % 3 != 0)
            {
                Console.WriteLine("Bizz");
            }
            else if (n % 3 != 0 && n % 5 != 0)
            { 
                Console.WriteLine(n); 
            }
            
        }

        

        
    }
}
