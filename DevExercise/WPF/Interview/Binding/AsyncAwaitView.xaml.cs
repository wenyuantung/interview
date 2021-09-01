using System;
using System.Threading.Tasks;
using System.Windows;

namespace Interview.Binding
{
    /// <summary>
    ///     Interaction logic for AsyncAwaitView.xaml
    /// </summary>
    public partial class AsyncAwaitView
    {
        public AsyncAwaitView()
        {
            InitializeComponent();
            ViewModel = new AsyncViewModel();
        }

        private AsyncViewModel ViewModel
        {
            get { return DataContext as AsyncViewModel; }
            set { DataContext = value; }
        }

        private async void OnClickChangeName(object sender, RoutedEventArgs e)
        {
            try
            {
                await ChangeName();
            }
            catch(Exception ex)
            {
                //Why can the exception be caught?
                //Find a way to catch exception here.
                MessageBox.Show(ex.ToString());
            }
        }

        private async Task ChangeName()
        {
            //Cannot do this. You need to find another way 
            //try
            //{
                await Task.Run(() =>
                {
                    throw new UnauthorizedAccessException();
                });
            //}
            //catch
            //{
            //}
        }
    }
}