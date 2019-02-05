namespace Lesson3.Tests
{
    using Lesson3b;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestsB
    {
        [TestMethod]
        public void SimpleTest1()
        {
            // Arrange
            var solB = new SolutionB();
            var expected = 4;

            // Act
            var actual = solB.solution(new int[] { 2, 3, 1, 5 });

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SimpleTest2()
        {
            // Arrange
            var solB = new SolutionB();
            var expected = 1;

            // Act
            var actual = solB.solution(new int[] { 2 });

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SimpleTest3()
        {
            // Arrange
            var solB = new SolutionB();
            var expected = 1;

            // Act
            var actual = solB.solution(new int[] { });

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
