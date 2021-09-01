using System.Windows;
using Interview.Data;

namespace Interview.Binding
{
    /// <summary>
    /// Interaction logic for DataBindng1.xaml
    /// </summary>
    public partial class DataBindng1n1
    {
        private readonly Person _person = new Person(){Name = "John Doe"};
        public DataBindng1n1()
        {
            InitializeComponent();
            //TODO: Make binding Text="{Binding Name} effective."
            DataContext = _person;
        }

        private void Show(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_person.Name);
        }
    }
}
