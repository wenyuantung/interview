using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCSharp
{
    public class CSharpExercise12
    {
        // Write a function to reverse a list
        public static void ReverseList<T>(IList<T> list)
        {
        }
    }


    [TestClass]
    public class TestCSharpExercise12
    {
        [TestMethod]
        public void TestReverseList()
        {
            var list = Enumerable.Range(1, 10).ToList();
        }
    }
}
