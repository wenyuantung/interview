using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;
using Interview.Data;

namespace Interview.Binding
{
    /// <summary>
    ///     Interaction logic for DataBinding2.xaml
    /// </summary>
    public partial class DataBinding2
    {
        public DataBinding2()
        {
            InitializeComponent();
            ViewModel = new Person(){Name = "John Doe", Age = 36};
        }

        private Person ViewModel
        {
            get { return DataContext as Person; }
            set { DataContext = value; }
        }

        private void ShowPersonNameAge(object sender, RoutedEventArgs e)
        {
            var message = ViewModel.Name + " is " + ViewModel.Age;
            MessageBox.Show(message);
        }

        private void AddAge(object sender, RoutedEventArgs e)
        {
            ViewModel.Age += 0.1;
            ageText.GetBindingExpression(TextBox.TextProperty)?.UpdateTarget();
        }
    }
}