﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Assignments
{
    class Program7
    {
            static void Main(string[] args)
            {
                int num, x;

                Console.WriteLine("\n----------*Display ODD factors of given number*----------\n");
                Console.WriteLine("Enter the Number ");
                num = int.Parse(Console.ReadLine());

                Console.WriteLine("The Odd Factors are : ");

                for (x = 1; x <= num; x++)
                {
                    if (num % x == 0)
                    {
                        if (x % 2 != 0)
                        {
                            Console.WriteLine(x);
                        }
                    }
                }

                Console.ReadLine();
            }
        }
    }