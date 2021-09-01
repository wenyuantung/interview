using System.Windows;
using Interview.Data;

namespace Interview.Binding
{
    /// <summary>
    /// Interaction logic for DataBinding3.xaml
    /// </summary>
    public partial class DataBinding3
    {
        public DataBinding3()
        {
            InitializeComponent();
            ViewModel = new Person();
        }

        private Person ViewModel
        {
            get {return DataContext as Person;} 
            set {DataContext = value;} 
        }
    }
}
