using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Assignments
{
    class Program11
    {
        static void Main(string[] args)
        {
            int num, x;

            Console.WriteLine("\n----------*Display of COUNT of EVEN factors of given number*----------\n");
            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("The Count of Even Factors are : ");

            int count = 0;

            for (x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    if (x % 2 == 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
