using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
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

		[TestMethod]
		public void TwoFactorialIsTwo()
		{
			//Arrange
			var NumberUnderTestTwo = 2;

			//Act
			var resultTwo = Factorial.Calculate(NumberUnderTestTwo);

			//Assert
			Assert.AreEqual(2, resultTwo, "The factorial for 2 is not 2");
		}

		[TestMethod]
		public void FiveFactorialIsOneHundredAndTwenty()
		{
			//Arrange
			var NumberUnderTestFive = 5;

			//Act
			var resultTwo = Factorial.Calculate(NumberUnderTestFive);

			//Assert
			Assert.AreEqual(120, resultTwo, "The factorial for 5 is not 120");
		}
	}
}
