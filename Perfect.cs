using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Assignments
{
    class Perfect
    {
        static void Main(string[] args)
        {
            int number, sum = 0;
            string divisors = "";
            Console.WriteLine("\n----------*To Find a Number is Perfect or not*----------\n");
            Console.Write("\nEnter Number: \n");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                    divisors += i.ToString() + "+";
                }
            }
            divisors = divisors.Remove(divisors.Length - 1, 1);
            
            Console.WriteLine("\n" + divisors + " = " + sum + "\n");

            //checking whether the number is Perfect or not
            if (sum == number)
            {
                Console.WriteLine("\n" + number + " Is A Perfect Number\n");
            }
            else
                Console.WriteLine("\n" + number + " Is Not A Perfect Number\n");
        }
    }
}
