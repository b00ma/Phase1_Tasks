using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Assignments
{
	class Program1
	{
		public static void Main(string[] args)
		{
			int i, n, sum = 0;
			Console.WriteLine("Enter the value of n :");

			n = Convert.ToInt32(Console.ReadLine());

			//to calculate sum of numbers
			for (i = 1; i <= n; i++)
			{
				if((i%5!=0)&&(i%7!=0)) //Condition to exclude factors of 5 and 7
				sum += i;
			}

			Console.WriteLine("Total sum: " + sum);
		}
	}
}
