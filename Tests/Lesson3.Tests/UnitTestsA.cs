namespace Lesson3.Tests
{
    using Lesson3a;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestsA
    {
        [TestMethod]
        public void SimpleTest1()
        {
            // Arrange
            var solA = new SolutionA();
            var expected = 3;

            // Act
            var actual = solA.solution(10, 85, 30);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SimpleTest2()
        {
            // Arrange
            var solA = new SolutionA();
            var expected = 0;

            // Act
            var actual = solA.solution(10, 10, 1);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
