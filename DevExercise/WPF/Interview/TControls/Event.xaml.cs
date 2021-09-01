using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Interview.TControls
{
    /// <summary>
    /// Interaction logic for Event.xaml
    /// </summary>
    public partial class Event
    {
        public Event()
        {
            InitializeComponent();
        }

        private void OnClickStackPanel(object sender, RoutedEventArgs e)
        {
            Trace.WriteLine("Click " + ((StackPanel)sender).Name);
        }

        private void OnClickButton(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Trace.WriteLine("Click " + ((Button)sender).Name);
        }
    }
}
