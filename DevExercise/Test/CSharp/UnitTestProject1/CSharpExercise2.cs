using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCSharp
{
    // This class is in another module and can't be modified
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }


        public virtual string GetName()
        {
            return FirstName + " " + LastName;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }        
    }

    public class MyPerson : Person
    {
        // 1. Output name in format "LastName, FirstName"

        // 2. Output GetAge() as Person.GetAge() + 1
    }

    [TestClass]
    public class TestCSharpExercise2
    {
        Person GetPerson()
        {
            return new MyPerson {FirstName = "John", LastName = "Dong", BirthDate = new DateTime(1998, 1, 1)};
        }
        [TestMethod]
        public void TestInheritance()
        {
            var person = GetPerson();          
        }
    }
}
