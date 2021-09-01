using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Prism.Commands;
using Prism.Events;

namespace WpfExercise
{
    public class PersonEvent: PubSubEvent<Person>
    {
    }

    public sealed class Person
    {
        private readonly IEventAggregator _eventAggregator;

        public Person()
        {
            
        }
     
        public Person(IEventAggregator ev)
        {
        }

        public DelegateCommand AddAgeCommand { get; private set; }

        public string Name { get; set; }

        public string Age { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            return string.Format("I am {0}, {1} years old, live in {2}", (Name ?? "John Doe"), (Age ?? "36"), (Address ?? "1001 Main Strees, Houston 77001"));
        }

        #region implementation of abc interface
        public string this[string columnName]
        {
            get
            {
                var ret = string.Empty;
                switch(columnName)
                {
                    case "Age":
                        break;
                    case "Name":
                        break;
                    case "Addres":
                        break;
                }

                return ret;
            }
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }
        #endregion

       #region implementation of xyz interface
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}