using System.ComponentModel.Composition.Hosting;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using Interview.Data;

namespace Interview
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private const string Namespace = "Interview.TControls";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var cmd = (Button)e.OriginalSource;
            var type = GetType();
            var assembly = type.Assembly;                       
            var win = (Window)assembly.CreateInstance(cmd.Tag + "." + cmd.Content);

            win?.ShowDialog();
        }
    }
}
