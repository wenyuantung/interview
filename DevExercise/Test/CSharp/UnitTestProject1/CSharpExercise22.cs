using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCSharp
{
    public class Parent
    {
        public Parent()
        {
            DoSomething();
        }

        protected virtual void DoSomething()
        {
        }
    }

    public class Child : Parent
    {
        public string Foo;

        public Child()
        {
            Foo = "HELLO";
        }

        protected override void DoSomething()
        {
            Console.WriteLine(Foo.ToLower());
        }
    }

    [TestClass]
    public class TestCSharpExercise22
    {
        [TestMethod]
        public void TestVirtualFunction2()
        {
            var child = new Child();
            Assert.IsTrue(true);

        }
    }
}
