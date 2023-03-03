using Challenge12.Utilities;
using System.Windows.Input;

namespace Challenge12.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand CustomersCommand { get; set; }
        public ICommand OrdersCommand { get; set; }
        public ICommand DefaultCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeVM();
        private void Customer(object obj) => CurrentView = new CustomerVM();
        private void Order(object obj) => CurrentView = new OrderVM();
        private void Default(object obj) => CurrentView = new DefaultVM();


        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            CustomersCommand = new RelayCommand(Customer);
            OrdersCommand = new RelayCommand(Order);
            DefaultCommand = new RelayCommand(Default);

            // Startup Page
            CurrentView = new HomeVM();
        }
    }
}
