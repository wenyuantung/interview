using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Interview.Binding
{
    /// <summary>
    ///     Interaction logic for AsyncView.xaml
    /// </summary>
    public partial class AsyncCmdView
    {
        public AsyncCmdView()
        {
            InitializeComponent();
            ViewModel = new AsyncViewModel();
        }

        private AsyncViewModel ViewModel
        {
            get { return DataContext as AsyncViewModel; }
            set { DataContext = value; }
        }

//        private void ChangeNameOnClick(object sender, RoutedEventArgs e)
//        {
//            Task.Run(() => Thread.Sleep(1000)).ContinueWith(t => NameTextBox.Text = Utils.RandomString(10));
////            Task.Run(() => Thread.Sleep(10)).ContinueWith(t =>
////                Dispatcher.Invoke(() => NameTextBox.Text = Utils.RandomString(10)));
//        }

        //OR
        private async void ChangeNameOnClick(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => Thread.Sleep(10));
            NameTextBox.Text = Utils.RandomString(10);
        }
    }
}