using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Interview.Properties;

namespace Interview.Data
{
    public class Person : IDataErrorInfo
    {
        public Person()
        {
            Name = "John Doe";
            Age = 36;
            Address = "1001 Main St. Houston, TX 77001";
        }

        public string Name { get; set; }
        public string Address { get; set; }

        public double Age { get; set; }

        public override string ToString()
        {
            return $"{Name} is {Age} years old, live in  {Address}";
        }

        public string this[string columnName]
        {
            get
            {
                switch(columnName)
                {
                    case "Age":
                        if(Age < 20)
                            return "He is lying.";
                        break;
                    case "Name":
                        break;
                    case "Address":
                        break;

                    default: throw new ArgumentException(Resources.Person3_this_Unknown_property__ + columnName, nameof(columnName));
                }
                return string.Empty;
            }
        }

        public string Error => string.Empty;
    }
}