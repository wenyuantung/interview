using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Prism.Commands;

namespace Question2
{
    /// <summary>
    ///     Interaction logic for AsyncCmdView.xaml
    /// </summary>
    public sealed partial class AsyncCmdView : INotifyPropertyChanged
    {
        private string _randomString;

        public AsyncCmdView()
        {
            InitializeComponent();
            ChangeNameCmd = new DelegateCommand(ChangeNameOnCommand);
            cmdButton.Command = ChangeNameCmd;
            RandomString = Utils.RandomString(10);
        }

        public DelegateCommand ChangeNameCmd { get; set; }

        public string RandomString
        {
            get { return _randomString; }
            set
            {
                _randomString = value;
                OnPropertyChanged();
            }
        }

        //TODO: Question: Why doesn't it work?
        private void ChangeNameOnClick(object sender, RoutedEventArgs e)
        {
            Task.Run(() => Thread.Sleep(10)).ContinueWith(t => NameTextBox.Text = Utils.RandomString(10));
        }
        //TODO: Question: Why does it work?
        private void ChangeNameOnCommand()
        {
            Task.Run(() => Thread.Sleep(10)).ContinueWith(t => RandomString = Utils.RandomString(10));
        }

        #region INotifyPropertyChanged

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        #endregion
    }
}