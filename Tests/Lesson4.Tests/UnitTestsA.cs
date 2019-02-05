namespace Lesson4.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTestsA
    {
        [TestMethod]
        public void SimpleTest1()
        {
            // Arrange
            var sol = new Solution4a();

            // Act
            var actual = sol.solution(new int[] { 1, 2, 3, 4, 5 });

            // Assert
            Assert.IsTrue(actual == 1);
        }

        [TestMethod]
        public void SimpleTest2()
        {
            // Arrange
            var sol = new Solution4a();

            // Act
            var actual = sol.solution(new int[] { 1, 3, 2, 5, 4 });

            // Assert
            Assert.IsTrue(actual == 1);
        }

        [TestMethod]
        public void SimpleTest3()
        {
            // Arrange
            var sol = new Solution4a();

            // Act
            var actual = sol.solution(new int[] { 1, 2, 4, 5 });

            // Assert
            Assert.IsTrue(actual == 0);
        }

        [TestMethod]
        public void SimpleTest4()
        {
            // Arrange
            var sol = new Solution4a();
            const int Max = 100000;
            var largeArray = new int[Max];
            for(int i=0;i<Max;i++)
            {
                largeArray[i] = i + 1;
            }

            // Act
            var actual = sol.solution(largeArray);

            // Assert
            Assert.IsTrue(actual == 1);
        }
    }
}
