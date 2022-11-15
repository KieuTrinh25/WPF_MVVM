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
    public class EditUserViewModel : ViewModelBase
    {
        private String _name;
        private String _phone;
        private String _password;
        public ICommand UpdateUserCommand { get; }
        public int Id { get; set; }
        public EditUserViewModel(int id)
        {
            this.Id = id;
            UpdateUserCommand = new ViewModelCommand(ExecuteUpdateUserCommand);
            InitData();
        }

        private void InitData()
        {
            UserDao userDao = DataDao.Instance().GetUserDao();
            User user = userDao.findById(Id);
            Phone = user.Phone;
            Password = user.Password;
        }
        private void ExecuteUpdateUserCommand(object obj)
        { 
            UserDao userDao = DataDao.Instance().GetUserDao();
            User user = userDao.findById(Id);
            user.Phone = _phone;
            user.Password = _password;
            userDao.update(user);
        }
        public string Name {
            get => _name; 
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
    }
}
