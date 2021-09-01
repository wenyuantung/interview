using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfExercise
{
    public sealed class Employee
    {
        public Employee()
        {
            Name = "John Doe";
            YearsOfService = "5";
            Salary = 80000;
        }

        public string Name { get; set; }

        public string YearsOfService { get; set; }

        public double Salary { get; set; }

        public override string ToString()
        {
            return string.Format("I am {0}, {1} years old, live in {2}", Name, YearsOfService, Salary);
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}