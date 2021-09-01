using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCSharp
{
    public class CSharpExercise32
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as CSharpExercise32;
            if (other == null)
            {
                return false;
            }
            return FirstName == other.FirstName &&
                   LastName == other.LastName;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    [TestClass]
    public class TestEquality
    {
        [TestMethod]
        public void TestValueEquality()
        {
            int i = 1;
            int j = 1;
            Assert.IsTrue(i == j);
            Assert.IsTrue(i.Equals(j));
            Assert.IsTrue(ReferenceEquals(i, j));
        }

        [TestMethod]
        public void TestObjectEquality()
        {
            var name1 = new CSharpExercise32 {FirstName = "John", LastName = "Dong"};
            var name2 = new CSharpExercise32 { FirstName = "John", LastName = "Dong" };
            Assert.IsTrue(name1.Equals(name2));
            Assert.IsTrue(name1 == name2);
            Assert.IsTrue(ReferenceEquals(name1, name2));
        }

        [TestMethod]
        public void TestStringEquality()
        {
            string s1 = "test2";
            string s2 = "test2";
            for (int i = 0; i < 3; i++)
            {
                s2 = "test" + i;
            }

            Assert.IsTrue(s1.Equals(s2));
            Assert.IsTrue(s1 == s2);
            Assert.IsTrue(ReferenceEquals(s1, s2));
        }
    }
}
