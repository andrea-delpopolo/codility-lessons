using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lesson1.Tests
{
	[TestClass]
	public class UnitTests
	{
		[TestMethod]
		public void AcceptanceTest1()
		{
			// Arrange
			var solution = new Solution();
			var input = 1041;

			// Act
			var result = solution.Solve(input);

			// Assert
			Assert.AreEqual(5, result);
		}

		[TestMethod]
		public void AcceptanceTest2()
		{
			// Arrange
			var solution = new Solution();
			var input = 32;

			// Act
			var result = solution.Solve(input);

			// Assert
			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void AcceptanceTest3()
		{
			// Arrange
			var solution = new Solution();
			var input = 15;

			// Act
			var result = solution.Solve(input);

			// Assert
			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void AcceptanceTest4()
		{
			// Arrange
			var solution = new Solution();
			var input = -1;

			// Act and assert
			var result = Assert.ThrowsException<ArgumentOutOfRangeException>(() => solution.Solve(input));
		}

		[TestMethod]
		public void AcceptanceTest5()
		{
			// Arrange
			var solution = new Solution();
			var input = 0;

			// Act and assert
			var result = Assert.ThrowsException<ArgumentOutOfRangeException>(() => solution.Solve(input));
		}

		[TestMethod]
		public void AcceptanceTest6()
		{
			// Arrange
			var solution = new Solution();
			var input = Int32.MaxValue;

			// Act
			var result = solution.Solve(input);

			// Assert
			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void AcceptanceTest7()
		{
			// Arrange
			var solution = new Solution();
			var input = 1223333334;
			// 1001000111010101001010111010110

			// Act
			var result = solution.Solve(input);

			// Assert
			Assert.AreEqual(3, result);
		}

		[TestMethod]
		public void AcceptanceTest8()
		{
			// Arrange
			var solution = new Solution();
			var input = 529;
			// 1000010001

			// Act
			var result = solution.Solve(input);

			// Assert
			Assert.AreEqual(4, result);
		}
	}
}
