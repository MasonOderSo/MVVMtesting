using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMtesting.Utilities;
using System.Windows.Input;
using MVVMtesting.Properties;
using MVVMtesting.ViewModel;

namespace MVVMtesting.Utilities
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand Window1Command { get; set; }
        public ICommand Window2Command { get; set; }

        private void Window1(object obj) => CurrentView = new Window1VM();
        private void Window2(object obj) => CurrentView = new Window2VM();
        public NavigationVM()
        {
            Window1Command = new RelayCommand(Window1);
            Window2Command = new RelayCommand(Window2);

            // Startup Page
            CurrentView = new Window1VM();
        }
    }
}
