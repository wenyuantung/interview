using System.Windows;

namespace WpfExercise
{
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var outputWindow = new EmployeeViewer();
            var inputWindow  = new EmployeeeEntryFrom();

            Current.MainWindow = inputWindow;
            inputWindow.Show();

            outputWindow.Owner = inputWindow;
            outputWindow.Top   = inputWindow.Top;
            outputWindow.Left  = inputWindow.Width + inputWindow.Left + 10;

            outputWindow.Show();
        }
    }
}