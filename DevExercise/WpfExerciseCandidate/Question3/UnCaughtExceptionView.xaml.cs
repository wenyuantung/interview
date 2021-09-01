using System;
using System.Threading.Tasks;
using System.Windows;

namespace Question3
{
    public partial class UnCaughtExceptionView
    {
        //TODO: Modify code to crash exception

        public UnCaughtExceptionView()
        {
            InitializeComponent();
        }

        private void OnClickChangeName(object sender, RoutedEventArgs e)
        {
            ChangeName();
        }

        private void ChangeName()
        {
            Task.Run(() => { throw new NotImplementedException(); });
        }
    }
}