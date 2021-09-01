using System.Windows;
using System.Windows.Input;

namespace Interview.TControls
{
    /// <summary>
    /// Interaction logic for Command.xaml
    /// </summary>
    public partial class Command : Window
    {
        public Command()
        {
            InitializeComponent();
            EnableCopyButton();
        }

        private void EnableCopyButton()
        {
            CommandBinding copy = new CommandBinding(ApplicationCommands.Copy);
            CommandBindings.Add(copy);

            copy.Executed += Copy_Executed;
        }

        private void Copy_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            
        }
    }
}
