using System;

namespace Phase1Assignments
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0, temp;
               
            Console.WriteLine("\n ----------*To Find a Number is Palindrome or not*----------\n");
            Console.Write("\n Enter a number: \n");
            num = Convert.ToInt32(Console.ReadLine());

            temp = num;

            while (num > 0)
            {
                rem = num % 10;     
                num = num / 10;     
                sum = sum * 10 + rem;
            }

            Console.WriteLine("\n The Reversed Number is: {0} \n", sum);

            //checking whether the reversed number is equal to entered number
            if (temp == sum)     
            {
                Console.WriteLine("\n Number is Palindrome \n\n");
            }
            else
            {
                Console.WriteLine("\n Number is not a palindrome \n\n");
            }
        }
    }
}
