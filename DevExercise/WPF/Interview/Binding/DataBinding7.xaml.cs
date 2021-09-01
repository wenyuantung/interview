using Interview.Data;

namespace Interview.Binding
{
    /// <summary>
    ///     Interaction logic for DataBinding3.xaml
    /// </summary>
    public partial class DataBinding7
    {
        public DataBinding7()
        {
            InitializeComponent();
            ViewModel =
                new Person {Name = "John Doe", Age = 36, Address = "22 Joeph St. Houston 77001"};
        }

        private Person ViewModel
        {
            get { return DataContext as Person; }
            set { DataContext = value; }
        }
    }
}