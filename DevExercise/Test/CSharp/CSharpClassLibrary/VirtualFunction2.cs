using System;

namespace CSharpClassLibrary
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
        private readonly string _foo;

        public Child()
        {
            _foo = "HELLO";
        }

        protected override void DoSomething()
        {
            Console.WriteLine(_foo.ToLower());
        }
    }

}
