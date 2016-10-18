using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace nFactorial
{
	class Program
	{
		static void Main(string[] args)
		{
			//Start the stopwatch for benchmarking execution time
			var executionTime = Stopwatch.StartNew();

			//Try parse the value given as input
			try
			{
				var input = ulong.Parse(args[0]);
				//Write the factorial value to the console as output
				Console.WriteLine(Factorial.Calculate(input).ToString());
			}
			//Catch the relevant exceptions
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("Please add a valid real integer as a command line parameter to calculate it's factorial value");
			}
			catch (FormatException)
			{
				Console.WriteLine("Please ensure that the value added as a command line parameter is a valid real integer");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			executionTime.Stop();

			//Write the benchmarking results to the console
			Console.WriteLine($"Execution time was {executionTime.ElapsedMilliseconds} milliseconds");
			Console.ReadKey();
			
		}
	}
}
