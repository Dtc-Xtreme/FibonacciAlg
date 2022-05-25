using System;

namespace FibonacciAlg // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(int x in GetFibonacciList())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine(FibonacciRecursive(2).ToString());
        }

        static List<int> GetFibonacciList()
        {
            List<int> list = new List<int>();
            int a = 0;
            int b = 1;
            bool forRun = false;

            // Add 0.
            list.Add(a);

            if (forRun)
            {
                // Runs x amount of times.
                int runCounts = 10;
                for (int i = 0; i < runCounts - 1; i++)      // -1 run because 0 is already added.
                {
                    list.Add(CalcNext(ref a, ref b));
                }
            }
            else
            {
                // Keeps runnin as long the last number is smaller then x.
                int x = 10946;
                while (list[list.Count-1] < x)
                {
                    list.Add(CalcNext(ref a, ref b));
                }
            }

            return list;
        }

        static int CalcNext(ref int a, ref int b)
        {
            int result = a + b;
            a = b;
            b = result;
            return result;
        }

        static int FibonacciRecursive(int number)
        {
            if (number < 2)
            {
                return number;
            }
            else
            {
                return FibonacciRecursive(number - 1) + FibonacciRecursive(number - 2);
            }
        }
    }
}