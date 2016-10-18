using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using nFactorial;

namespace nFactorialTests
{
	[TestClass]
	public class FactorialTests
	{
		[TestMethod]
		public void NumberLessThanOneFactorialIsOne()
		{
			//Arrange
			var NumberUnderTestZero = 0;
			var NumberUnderTestOne = 0;

			//Act
			var resultZero = Factorial.Calculate(NumberUnderTestZero);
			var resultOne = Factorial.Calculate(NumberUnderTestOne);

			//Assert
			Assert.AreEqual(1,resultZero,"The factorial for 0 is not 1");
			Assert.AreEqual(1, resultOne, "The factorial for 1 is not 1");

		}
	}
}
