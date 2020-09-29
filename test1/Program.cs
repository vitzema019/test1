using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
           
        {
            Console.WriteLine(PowerOfTWo(Convert.ToInt32(Console.ReadLine())));

        }

        static int PowerOfTWo(int n)
        {

            int result = n * n;
            return result;
        
        }
    }
}
