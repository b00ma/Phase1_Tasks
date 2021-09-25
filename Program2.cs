using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Assignments
{
    class Program2
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("\n----------*Display of Characters*----------\n");
            Console.WriteLine("\n1. (A-Z)\n2. (Z-A)\n3. (a-z)\n4. (z-a)\n5. Characters in both Upper and Lower Case\n");
            Console.WriteLine("\nEnter your choice:\n");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    char alpha;
                    for (alpha = 'A'; alpha <= 'Z'; alpha++)
                    {
                        Console.Write("{0} ", alpha);
                    }
                break;
                
                case 2:
                    
                    for (alpha = 'Z'; alpha >= 'A'; alpha--)
                    {
                        Console.Write("{0} ", alpha);
                    }
                    break;

                case 3:
                    
                    for (alpha = 'a'; alpha <= 'z'; alpha++)
                    {
                        Console.Write("{0} ", alpha);
                    }
                    break;

                case 4:
                    
                    for (alpha = 'z'; alpha >= 'a'; alpha--)
                    {
                        Console.Write("{0} ", alpha);
                    }
                    break;

                case 5:
                    
                    for (alpha = 'A'; alpha <= 'Z'; alpha++)
                    {
                        Console.Write("{0} ", alpha);
                    }
                    Console.WriteLine("\n");
                    for (alpha = 'a'; alpha <= 'z'; alpha++)
                    {
                        Console.Write("{0} ", alpha);
                    }
                    break;

                default:
                    Console.WriteLine("\nInvalid Input!!\n");
                    break;
            }
            Console.ReadKey();
        }
    }
}
