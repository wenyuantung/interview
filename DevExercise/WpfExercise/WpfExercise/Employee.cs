using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Prism.Commands;
using Prism.Events;

namespace WpfExercise
{
    public sealed class Employee : INotifyPropertyChanged, IDataErrorInfo, IDisposable
    {
        private readonly IEventAggregator _eventAggregator;
        private string _name;
        private double _salary;
        private string _yearsOfService;

        public Employee(IEventAggregator ev)
        {
            _eventAggregator = ev;
            RaiseSalaryCommand = new DelegateCommand(RaiseSalary);

            _name = "John Doe";
            _yearsOfService = "5";
            _salary = 80000;

            _eventAggregator.GetEvent<EmployeeEvent>().Publish(this);
        }

        public DelegateCommand RaiseSalaryCommand { get; private set; }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
                _eventAggregator.GetEvent<EmployeeEvent>().Publish(this);
            }
        }

        public string YearsOfService
        {
            get { return _yearsOfService; }
            set
            {
                _yearsOfService = value;
                OnPropertyChanged();
                _eventAggregator.GetEvent<EmployeeEvent>().Publish(this);
            }
        }

        public double Salary
        {
            get { return _salary; }
            set
            {
                _salary = value;
                OnPropertyChanged();
                _eventAggregator.GetEvent<EmployeeEvent>().Publish(this);
            }
        }

        private double _YearsOfService
        {
            get
            {
                double ys;
                if(double.TryParse(YearsOfService, out ys))
                    return ys;
                return -1;
            }
        }

        public override string ToString()
        {
            return string.Format("I am {0}, {1} years old, live in {2}", Name, YearsOfService, Salary);
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void RaiseSalary()
        {
            Salary += Salary * 0.03;
        }

        public string this[string columnName]
        {
            get
            {
                var ret = string.Empty;
                switch(columnName)
                {
                    case "YearsOfService":
                        if(_YearsOfService <= 0)
                            ret = "Not employeeed";
                        break;
                    case "Name":
                        break;
                    case "Salary":
                        break;
                }

                return ret;
            }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public void Dispose()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };
    }
}