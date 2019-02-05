namespace Lesson3.Tests
{
    using Lesson3c;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestsC
    {
        [TestMethod]
        public void SimpleTest1()
        {
            // Arrange
            var solC = new SolutionC();
            var expected = 1;

            // Act
            var actual = solC.solution(new int[] { 3, 1, 2, 4, 3 });

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
