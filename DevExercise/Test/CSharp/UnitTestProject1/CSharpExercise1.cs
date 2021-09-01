using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCSharp
{
    public class CSharpExercise1
    {
        // 1. Write a function to remove all the content of a list ONE BY ONE. Write a unit test to verify the results
        public static void RemoveContentOfList<T>(IList<T> list)
        {
        }       
    }


    [TestClass]
    public class TestCSharpExercise1
    {
        [TestMethod]
        public void TestRemoveContentOfListOneByOne()
        {
            var list = Enumerable.Range(1, 10).ToList();
        }
    }
}
