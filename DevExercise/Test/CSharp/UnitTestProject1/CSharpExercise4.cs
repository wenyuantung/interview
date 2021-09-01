using System;
using CSharpClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCSharp
{
    [TestClass]
    public class CSharpExercise4
    {
        [TestMethod]
        public void TestExxeption0()
        {
            // What is the output?
            try
            {
                ExceptionTest.Exception1();

            }
            catch (Exception)
            {
            }
        }

        [TestMethod]
        public void TestExxeption1()
        {
            // What is the output?
            try
            {
                ExceptionTest.Exception1();

            }
            catch (Exception)
            {
            }
        }

        [TestMethod]
        public void TestExxeption2()
        {
            // What is the output?
             ExceptionTest.Exception2();

            
        }

        [TestMethod]
        public void TestExxeption3()
        {
            // What is the output?
             ExceptionTest.Exception3();
          
        }
    }
}
