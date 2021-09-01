using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCSharp
{
    public interface IEmployee
    {
        Guid Uid { get; }
        string Name { get; set; }
        double Salary { get; set; }
    }

    public class Employee : IEmployee
    {
        public Employee()
        {
            Uid = new Guid();
        }
        public Guid Uid { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }

    public interface IEmployeeCollection
    {
        IEnumerable<IEmployee> Employees { get; }
    }

    /// ----------------------------------------------//

    public class MyEmployee : IEmployee
    {
        public MyEmployee()
        {
            Uid = new Guid();
        }
        public Guid Uid { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public double Bonus { get; set; }
    }


    public class EmployeeCollection : IEmployeeCollection
    {   
        List<MyEmployee> _myEmployees = new List<MyEmployee>
        {
            new MyEmployee {Name = "Jonn Dong", Salary = 50000, Bonus = 3.0},
            new MyEmployee {Name = "Bob Doyle", Salary = 40000, Bonus = 2.0}
        };
        

        public IEnumerable<IEmployee> Employees
        {
            get
            {
                foreach (var employee in _myEmployees)
                {
                    yield return employee;
                }
            }
        }

        public IEnumerable<MyEmployee> MyEmployees => _myEmployees;

        public void Update(IList<IEmployee> employees)
        {
            // Update employee info for an existing employee
            // Add new employee to _myEmployees
            // Delete empolyees that is no longer in _myEmployees
        }
    }


    [TestClass]
    public class TestEmployeeMerge
    {
        [TestMethod]
        public void TestUpdate()
        {
            var employeeCollection = new EmployeeCollection();
            var employees = employeeCollection.Employees.ToList();
            
            employees[0].Salary = 51000;
            employees.RemoveAt(1);
            employees.Add(new Employee { Name = "James King", Salary = 60000});
            employeeCollection.Update(employees);

            Assert.AreEqual(2, employees.Count);
            //var employee1 = e

               
        }    
    }
}

