using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
           
        {
            while (true)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a > 2 && a < 17)
                    {
                    Console.WriteLine(PowerOfTWo(a));
                    break;
                }
            }
            

        }

        static int PowerOfTWo(int n)
        {

            int result = n * n;
            return result;
        
        }
    }
}
