using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCSharp
{
    public class CSharpExercise5
    {
        public static Func<int, int> Increase()
        {
            var count = 0;
            return input => input + (++count);
        }
    }


    [TestClass]
    public class TestCSharpExercise5
    {      
        [TestMethod]
        public void TestFunc()
        {
            var increase = CSharpExercise5.Increase();
            Assert.AreEqual(2, increase(1));
            Assert.AreEqual(3, increase(2));
        }
    }
}
