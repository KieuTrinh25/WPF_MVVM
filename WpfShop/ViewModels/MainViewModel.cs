using FontAwesome.Sharp;
using System.Windows;
using System.Windows.Input;

namespace WpfShop.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        //Fields
        private ViewModelBase _currentChildView;
        private string _caption;
        private IconChar _icon;
        public ViewModelBase CurrentChildView
        {
            get
            {
                return _currentChildView;
            }
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }
        public string Caption
        {
            get
            {
                return _caption;
            }
            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }
        public IconChar Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value;
                OnPropertyChanged(nameof(Icon));
            }
        }
        //--> Commands
        public ICommand ShowHomeViewCommand { get; }
        public ICommand ShowUserViewCommand { get; }
        public ICommand ShowProductViewCommand { get; }
        public ICommand ShowCategoryViewCommand { get; }
        public ICommand ShowOrderViewCommand { get; }
        public ICommand ShowOrderDetailViewCommand { get; }

        public ICommand ShowLoginViewCommand { get; }

        public MainViewModel()
        {
            ShowUserViewCommand = new ViewModelCommand(ExecuteShowUserViewCommand);
            ShowProductViewCommand = new ViewModelCommand(ExecuteShowProductViewCommand);
            ShowCategoryViewCommand = new ViewModelCommand(ExecuteShowCategoryViewCommand);
            //Default view
            ExecuteShowUserViewCommand(null);
            ExecuteShowProductViewCommand(null);
            ExecuteShowCategoryViewCommand(null);

        }
        public void ExecuteShowUserViewCommand(object obj)
        {
            CurrentChildView = new UserViewModel(this);
            Caption = "Users";
            Icon = IconChar.User;
        }

        public void ExecuteShowProductViewCommand(object obj)
        {
            CurrentChildView = new ProductViewModel(this);
            Caption = "Products";
            Icon = IconChar.ShoppingBag;
        }
        public void ExecuteShowCategoryViewCommand(object obj)
        {
            CurrentChildView = new CategoryViewModel(this);
            Caption = "Categories";
            Icon = IconChar.Box;
        }
    }
}
