using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Commander;

namespace WpfProperty
{
    //[ImplementPropertyChanged]
    class MainViewModel : INotifyPropertyChanged
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        public MainViewModel()
        {
            FirstName = "Foo";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        [OnCommand("ClickCommand")]
        private void OnCommandExecuted(string value)
        {
            MessageBox.Show(value);
        }

        [OnCommandCanExecute("ClickCommand")]
        private bool CanExecuteCommand()
        {
            return string.IsNullOrEmpty(FirstName) == false;
        }
    }
}
