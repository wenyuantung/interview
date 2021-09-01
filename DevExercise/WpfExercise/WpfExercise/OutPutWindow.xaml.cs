using Prism.Events;

namespace WpfExercise
{
    /// <summary>
    /// Interaction logic for OutPutWindow.xaml
    /// </summary>
    public sealed partial class OutPutWindow
    {
        public OutPutWindow(IEventAggregator eventAggregator)
        {
            InitializeComponent();
            eventAggregator.GetEvent<EmployeeEvent>().Subscribe(UpdatePerson, keepSubscriberReferenceAlive:false);
        }

        private void UpdatePerson(Employee employee)
        {
            DataContext = employee;
        }
    }
}
