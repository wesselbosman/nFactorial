using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nFactorial
{
	/// <summary>
	/// Provides a set of static methods to calculate factorial values
	/// </summary>
	public class Factorial
	{
		/// <summary>
		/// Calculates the factorial value for the product of all the descending natural numbers of the given input
		/// </summary>
		/// <param name="n">The value for which the factorial number will be calculated</param>
		/// <returns>Returns the full factorial number which is a product of all the descending natural numbers given as input</returns>
		public static long Calculate(long n )
		{
			//Instantiate the initial total return to one
			var factorialTotal = 1;

			//Determine if the value is less or equal to one and return one in that case
			if (n <= 1)
			{
				return factorialTotal;
			}
			else
			{
				//For loop to calculate the product of all the descending natural numbers
				for (int i = 1; i <= n; i++)
				{
					factorialTotal = factorialTotal * i;
				}

				return factorialTotal;
			}
			
		}
	}
}
