using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Prism.Commands;

namespace Interview.Binding
{
    public class AsyncViewModel : INotifyPropertyChanged
    {
        private string _name;

        public AsyncViewModel()
        {
            Name = "John Doe";
            ChangeNameCmd = new DelegateCommand(ChangeName);
        }

        public DelegateCommand ChangeNameCmd { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private void ChangeName()
        {
            Task.Run(() => Thread.Sleep(10)).ContinueWith(t =>
            {
                _name = Utils.RandomString(8);
                OnPropertyChanged(nameof(Name));
            });
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}