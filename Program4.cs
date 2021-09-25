using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Assignments
{
    class Program4
    {
        public static void Main()
        {
            Console.WriteLine("\n----------*Display of Even Numbers from 25 to 15*----------\n");

            for (int n = 25; n >= (15 + 1); n--)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }
        }
    }
}
