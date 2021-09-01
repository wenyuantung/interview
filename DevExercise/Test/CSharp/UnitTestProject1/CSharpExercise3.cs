
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCSharp
{
    public class MethodOverloadding
    {
        public static string GetValue(int value)
        {
            return value.ToString();
        }

        public static string GetValue(double value)
        {
            return string.Format("{0: F2}", value);
        }

        public static string GetValue(string value)
        {
            return value;
        }

        public static string GetValue(object value)
        {
            return typeof(object).ToString();
        }
    }

    [TestClass]
    public class CSharpExercise3
    {
        [TestMethod]
        public void TestMethodOverloadding()
        {
            var value = 3;
            Assert.IsTrue(MethodOverloadding.GetValue(value) == "3");
        }

        [TestMethod]
        public void TestMethodOverloadding2()
        {
            object t = "this is a string";
            Assert.IsTrue(MethodOverloadding.GetValue(t) == "this is a string");
        }
    }
}
