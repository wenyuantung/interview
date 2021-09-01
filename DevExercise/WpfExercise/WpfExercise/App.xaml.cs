using System.Windows;
using Prism.Events;

namespace WpfExercise
{
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            EventAggregator eventAggregator = new EventAggregator();
            var outputWindow = new OutPutWindow(eventAggregator);
            var inputWindow = new InputWindow(eventAggregator);

            Current.MainWindow = inputWindow;
            inputWindow.Show();

            outputWindow.Owner = inputWindow;
            outputWindow.Top = inputWindow.Top;
            outputWindow.Left = inputWindow.Width + inputWindow.Left + 10;

            outputWindow.Show();
        }
    }
}