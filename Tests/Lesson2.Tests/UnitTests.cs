namespace Lesson2.Tests
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
            int[] input = new int[] { 9, 3, 9, 3, 9, 7, 9, 7, 7 };

            // Act
            var result = solution.Solve(input);

            // Assert
            Assert.AreEqual(7, result);
        }
    }
}
