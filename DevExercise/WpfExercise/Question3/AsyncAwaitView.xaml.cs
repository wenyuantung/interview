using System;
using System.Threading.Tasks;
using System.Windows;

namespace Question3
{
    /// <summary>
    ///     Interaction logic for AsyncAwaitView.xaml
    /// </summary>
    public partial class AsyncAwaitView
    {
        public AsyncAwaitView()
        {
            InitializeComponent();
        }

        private async void OnClickChangeName(object sender, RoutedEventArgs e)
        {
            try
            {
                await ChangeName();
            }
            catch(Exception ex)
            {
                //TODO: Question Why can the exception be caught?
                MessageBox.Show(ex.ToString());
            }
        }

        private async Task ChangeName()
        {
            //Cannot try-catch. You need to find another way 
            await Task.Run(() => { throw new UnauthorizedAccessException(); });
        }
    }
}