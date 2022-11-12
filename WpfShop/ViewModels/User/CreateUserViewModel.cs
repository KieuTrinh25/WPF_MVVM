using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfShop.ViewModels
{
    public class CreateUserViewModel : ViewModelBase
    {
        private String _email;
        private String _password;
        public ICommand CreateUserCommand { get; }

        public CreateUserViewModel()
        {
            CreateUserCommand = new ViewModelCommand(ExecuteCreateUserCommand);
        }

        private void ExecuteCreateUserCommand(object obj)
        {
            MessageBox.Show(Email);
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
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
