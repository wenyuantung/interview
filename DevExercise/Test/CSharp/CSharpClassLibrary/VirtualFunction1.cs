using System;


namespace CSharpClassLibrary
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

        public int Age()
        {
            return DateTime.Now.Year - BirthDate.Year;
        }        
    }

    public class MyPerson : Person
    {
        // TODO:
        // 1. Output name with in format "LastName, FirstName"
        // 2. Output Age as Person.Age() + 1
    }

    // TODO
    // 3. Add a method that get a person's ID (return type: string) 

}
