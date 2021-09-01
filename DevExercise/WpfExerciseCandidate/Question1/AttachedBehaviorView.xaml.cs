namespace Question1
{
    /// <summary>
    /// Interaction logic for AttachedBehaviorView.xaml
    /// </summary>
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
