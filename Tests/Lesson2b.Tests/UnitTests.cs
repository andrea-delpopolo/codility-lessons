namespace Lesson2b.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void SimpleTest1()
        {
            // Arrange
            var solution = new Solution();
            var input = new int[] { 3, 8, 9, 7, 6 };
            var expected = new int[] { 6, 3, 8, 9, 7 };

            // Act
            var actual = solution.Solve(input, 1);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SimpleTest2()
        {
            // Arrange
            var solution = new Solution();
            var input = new int[] { };
            var expected = new int[] { };

            // Act
            var actual = solution.Solve(input, 1);

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
