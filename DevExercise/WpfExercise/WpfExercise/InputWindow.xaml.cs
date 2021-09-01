using Prism.Events;

namespace WpfExercise
{
    /// <summary>
    ///     Interaction logic for InputWindow.xaml
    /// </summary>
    public partial class InputWindow
    {
        public InputWindow(IEventAggregator eventAggregator)
        {
            InitializeComponent();
            DataContext = new Employee(eventAggregator);
        }
    }
}