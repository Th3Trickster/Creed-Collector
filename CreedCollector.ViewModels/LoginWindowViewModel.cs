using CreedCollector.Models;
using CreedCollector.ViewModels.Commands;
using CreedCollector.ViewModels.Hashing;
using CreedCollector.ViewModels.LoggedInProperties;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CreedCollector.ViewModels
{
    public class LoginWindowViewModel : INotifyPropertyChanged
    {
        private User user;
        private SecureString password;
        private string username;

        public event PropertyChangedEventHandler PropertyChanged;

        public LoginCommand LoginCommand { get; set; }

        public User User
        {
            get { return user; }
            set
            {
                user = value;
                RaisePropertyChanged("User");
            }
        }

        public string UserName
        {
            get { return username; }
            set
            {
                username = value;
                RaisePropertyChanged("UserName");
            }
        }

        public SecureString PasswordSecureString
        {
            get { return password; }
            set
            {
                if (value != null)
                {
                    password = value;
                    RaisePropertyChanged("PasswordSecureString");
                }
            }
        }

        public RelayCommand ShowUserDashboardWindowView { get; private set; }

        public LoginWindowViewModel()
        {
            LoginCommand = new LoginCommand(this);
            ShowUserDashboardWindowView = new RelayCommand(ShowUserDashboardWindowViewCommandExecute);
        }

        /* This method will check if the user exists in the DB and also check the password. Password is salted and hashed.
         * After user has been authenticated with the DB that user's information which is need for the application is stored
         * in static properties in a seperate class, the method which stores the properties is SetUserInformation. Then
         * the message for opening the user dashboard is sent to the UserDashboardWindowView. */
        public void Login()
        {
            using (CreedCollectorEntities ctx = new CreedCollectorEntities())
            {
                User userLogin = ctx.Users
                                    .Where(User => User.UserName == this.UserName)
                                    .FirstOrDefault();

                if (userLogin == null)
                {
                    MessageBox.Show("User not found");
                    return;
                }

                byte[] enteredValueHash = PasswordHashing.CalculateHash(SecureStringManipulation.ConvertSecureStringToByteArray(PasswordSecureString));

                if (!PasswordHashing.SequenceEquals(enteredValueHash, userLogin.Password))
                {
                    MessageBox.Show("Incorrect Password Entered.");
                    return;
                }
                SetUserInformation();
                ShowUserDashboardWindowViewCommandExecute();
            }
        }

        // This method will set the User information in static methods which will be used throughout the application.
        private void SetUserInformation()
        {
            using (CreedCollectorEntities ctx = new CreedCollectorEntities())
            {
                User user = ctx.Users
                               .Where(User => User.UserName == this.UserName)
                               .FirstOrDefault();
                UserInformation.FirstName = user.FirstName;
                UserInformation.XboxLiveGamertag = user.XboxLiveGamertag;
                UserInformation.SteamUsername = user.SteamId;
                UserInformation.PsnName = user.PlaystationNetworkId;
            }
        }

        /* This method is used for sending a message to the UserDashboardWindowView which will
         * open once the user is authenticated in the DB.*/
        public void ShowUserDashboardWindowViewCommandExecute()
        {
            Messenger.Default.Send(new NotificationMessage("ShowUserDashboardWindowView"));
        }

        /* Used for MVVM purposes */
        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
