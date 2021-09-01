using Interview.Data;

namespace Interview.Binding
{
    public partial class AttachedBehaviorView
    {
        public AttachedBehaviorView()
        {
            InitializeComponent();
            ViewModel = new AttachedBehaviorViewModel();
        }

        public AttachedBehaviorViewModel ViewModel
        {
            get { return DataContext as AttachedBehaviorViewModel; }
            set { DataContext = value; }
        }
    }
}