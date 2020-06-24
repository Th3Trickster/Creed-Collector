using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CreedCollector.ViewModels.Commands
{
    public class LoginCommand : ICommand
    {
        public LoginWindowViewModel LoginWindowViewModel { get; set; }

        public LoginCommand(LoginWindowViewModel loginWindowViewModel)
        {
            LoginWindowViewModel = loginWindowViewModel;
        }

        public bool CanExecute(object parameter)
        {
            if (LoginWindowViewModel.PasswordSecureString != null &&
                LoginWindowViewModel.PasswordSecureString.Length > 0 &&
                !string.IsNullOrWhiteSpace(LoginWindowViewModel.UserName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute(object parameter)
        {
            LoginWindowViewModel.Login();
        }
    }
}
