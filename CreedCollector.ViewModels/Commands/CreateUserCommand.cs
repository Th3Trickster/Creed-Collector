using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CreedCollector.ViewModels.Commands
{
    public class CreateUserCommand : ICommand
    {
        public CreateAccountWindowViewModel CreateAccountWindowViewModel { get; set; }

        public CreateUserCommand(CreateAccountWindowViewModel createAccountWindowViewModel)
        {
            CreateAccountWindowViewModel = createAccountWindowViewModel;
        }

        public bool CanExecute(object parameter)
        {
            if (!string.IsNullOrWhiteSpace(CreateAccountWindowViewModel.FirstName) &&
                !string.IsNullOrWhiteSpace(CreateAccountWindowViewModel.LastName) &&
                !string.IsNullOrWhiteSpace(CreateAccountWindowViewModel.Email) &&
                !string.IsNullOrWhiteSpace(CreateAccountWindowViewModel.UserName) &&
                CreateAccountWindowViewModel.PasswordSecureString != null &&
                CreateAccountWindowViewModel.PasswordSecureString.Length > 0)
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
            CreateAccountWindowViewModel.CreateUser();
        }
    }
}
