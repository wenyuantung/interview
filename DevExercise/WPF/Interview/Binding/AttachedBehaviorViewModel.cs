using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Interview.Binding
{
    public class AttachedBehaviorViewModel : INotifyPropertyChanged
    {
        private string _address;
        private string _age;
        private string _name;

        public string Name
        {
            get {return _name;} 
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Address
        {
            get {return _address;} 
            set
            {
                _address = value;
                OnPropertyChanged();
            }
        }

        public string Age
        {
            get {return _age;} 
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public async void LoadViewModel()
        {
            await Task.Delay(10);

            Name = "John Doe";
            Age = "36";
            Address = "1001 Main St. Houston, TX 77001";
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}