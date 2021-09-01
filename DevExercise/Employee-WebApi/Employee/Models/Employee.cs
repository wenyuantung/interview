using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public List<Project> Projects { get; set; }

    }

    public class Project
    {
        public string Name { get; set; }
        public double WeeklyHours { get; set; }
    }
}
