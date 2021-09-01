using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCSharp
{
   [TestClass]
    public class LoopTest
    {
        [TestMethod]
        public void TestLoop()
        {
            var values = Enumerable.Range(1, 100).ToList();
            foreach (var value in values)
            {
                values.Remove(value);
            }
            Assert.IsTrue(values.Count == 0);
        }

        [TestMethod]
        public void TestLoop2()
        {
            var values = Enumerable.Range(1, 100).ToList();
            for (var index = 0; index < values.Count; index++)
            {
                var value = values[index];
                values.Remove(value);
            }
            Assert.IsTrue(values.Count == 0);
        }

        [TestMethod]
        public void TestLoop4()
        {
            var values = Enumerable.Range(1, 100).ToList();
            int count = values.Count;
            for (var index = 0; index < count; index++)
            {
                var value = values[index];
                values.Remove(value);
            }
            Assert.IsTrue(values.Count == 0);
        }

        [TestMethod]
        public void TestLoop5()
        {
            var values = Enumerable.Range(1, 100).ToList();
            values = new List<int>();
            do
            {
               values.RemoveAt(0);
            } while (values.Count > 0);
            Assert.IsTrue(values.Count == 0);
        }

        [TestMethod]
        public void TestLoop3()
        {
            var values = Enumerable.Range(1, 100).ToList();
            for (var index = values.Count - 1; index >= 0; index--)
            {
                var value = values[index];
                values.Remove(value);
            }
            Assert.IsTrue(values.Count == 0);
        }
    }
}
