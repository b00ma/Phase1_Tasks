using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Assignments
{
    class Program3
    {
        public static void Main()
        {
            Console.WriteLine("\n----------*Display of Odd Numbers from 2 to 10*----------\n");

            for (int n = 2; n < (10 + 1); n++)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());
                }
            }
        }
    }
}
