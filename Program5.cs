using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Assignments
{
    class Program5
    {
        public static void Main()
        {
            Console.WriteLine("\n----------*Display factors of 5 from 20 to 2*----------\n");

            for (int n = 20; n >= (2 + 1); n--)
            {
                if (n % 5 == 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }
        }
    }
}
