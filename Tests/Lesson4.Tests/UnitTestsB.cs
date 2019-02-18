namespace Lesson4.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class UnitTestsB
    {
        [TestMethod]
        public void SimpleTest1()
        {
            // Arrange
            var sol = new Solution4b();

            // Act
            var actual = sol.solution(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 });

            // Assert
            Assert.AreEqual(6, actual);
            
        }

        [TestMethod]
        public void SimpleTest2()
        {
            // Arrange
            var sol = new Solution4b();

            // Act
            var actual = sol.solution(4, new int[] { 1, 2, 3, 4 });

            // Assert
            Assert.AreEqual(3, actual);

        }

        [TestMethod]
        public void SimpleTest3()
        {
            // Arrange
            var sol = new Solution4b();

            // Act
            var actual = sol.solution(1, new int[] { 1 });

            // Assert
            Assert.AreEqual(0, actual);

        }

        [TestMethod]
        public void SimpleTest4()
        {
            // Arrange
            var sol = new Solution4b();

            // Act
            var actual = sol.solution(1, new int[] { });

            // Assert
            Assert.AreEqual(-1, actual);

        }

        [TestMethod]
        public void SimpleTest5()
        {
            // Arrange
            var sol = new Solution4b();
            var largeGap = new List<int>();

            largeGap.Add(1);
            largeGap.Add(2);
            largeGap.Add(3);
            largeGap.Add(4);

            for(int i=0;i<99000;i++)
            {
                largeGap.Add(2);
            }

            largeGap.Add(5);
            largeGap.Add(10);

            // Act
            var actual = sol.solution(5, largeGap.ToArray());

            // Assert
            Assert.AreEqual(99004, actual);

        }
    }
}
