using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfShop.Data.Dao;

namespace WpfShop.ViewModels
{
    public class UserViewModel : ViewModelBase
    {
        private MainViewModel _mainViewModel;
        private List<User> _userList;
        public List<User> UserList { get; }

        public ICommand ShowCreateUserViewCommand { get; }
        public UserViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
            ShowCreateUserViewCommand = new ViewModelCommand(ExecuteShowCreateUserViewCommand);
            UserDao userDao = DataDao.Instance().GetUserDao();
            UserList = userDao.findAll();
        }
        private void ExecuteShowCreateUserViewCommand(object obj)
        {
            _mainViewModel.CurrentChildView = new CreateUserViewModel();
            _mainViewModel.Caption = "Create Users";
            _mainViewModel.Icon = IconChar.User;
        }
    }
}
