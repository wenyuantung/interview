using System.Collections.ObjectModel;
using System.Windows;
using Interview.Data;

namespace Interview.Binding
{
    /// <summary>
    /// Interaction logic for DataBinding3.xaml
    /// </summary>
    public partial class DataBinding4
    {
        public DataBinding4()
        {
            InitializeComponent();
            ViewModel = new ObservableCollection<Person>()
            {
                new Person(){Name="John Doe", Age=36, Address = "22 Joeph St. Houston 77001"},
                new Person(){Name="Mary Lynn", Age=46, Address = "99 Wyling St. Houston 77479"},
            };
        }

        private ObservableCollection<Person> ViewModel
        {
            get { return DataContext as ObservableCollection<Person>; }
            set { DataContext = value; }
        }
    }
}
