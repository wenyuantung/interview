using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Prism.Commands;

namespace Question2
{
    public sealed class AsyncViewModel : INotifyPropertyChanged
    {
        private string _randomString;

        public AsyncViewModel()
        {
            RandomString = Utils.RandomString(8);
            ChangeNameCmd = new DelegateCommand(ChangeName);
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

        private void ChangeName()
        {
            Task.Run(() => Thread.Sleep(10)).ContinueWith(t =>
            {
                _randomString = Utils.RandomString(8);
                OnPropertyChanged(nameof(RandomString));
            });
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}