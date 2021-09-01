using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Question1
{
    public sealed class AttachedBehaviorViewModel : INotifyPropertyChanged
    {
        private string _address;
        private string _age;
        private string _name;

        public async void LoadData()
        {
            await Task.Delay(1000); //lengthy processing

            Name = "John Doe";
            Age = "36";
            Address = "1001 Main St. Houston, TX 77001";
        }

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

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
    }
}