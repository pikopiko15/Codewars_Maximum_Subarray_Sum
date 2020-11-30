using Codewars_Maximum_Subarray_Sum;
using NUnit.Framework;

namespace Codewars_Maximum_Subarray_Sum_Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test0()
        {
            Assert.AreEqual(0, Kata.MaxSequence(new int[0])); // Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test1()
        {
         // Assert.AreEqual(expected, actual);
            Assert.AreEqual(6, Kata.MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }
    }
}