﻿using CreedCollector.Models;
using CreedCollector.ViewModels.Commands;
using CreedCollector.ViewModels.Hashing;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CreedCollector.ViewModels
{
    public class CreateAccountWindowViewModel : INotifyPropertyChanged
    {
        private User user;
        private string firstName;
        private string lastName;
        private string email;
        private string username;
        private SecureString password;
        private string xboxLiveGamertag;
        private string steamUsername;
        private string psnName;

        public CreateUserCommand CreateUserCommand { get; set; }

        public string XboxLiveGamertag
        {
            get { return xboxLiveGamertag; }
            set
            {
                xboxLiveGamertag = value;
                RaisePropertyChanged("XboxLiveGamertag");
            }
        }

        public string SteamUsername
        {
            get { return steamUsername; }
            set
            {
                steamUsername = value;
                RaisePropertyChanged("SteamUsername");
            }
        }

        public string PsnName
        {
            get { return psnName; }
            set
            {
                psnName = value;
                RaisePropertyChanged("PsnName");
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                RaisePropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                RaisePropertyChanged("LastName");
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                RaisePropertyChanged("Email");
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

        public RelayCommand ShowLoginWindowView { get; private set; }

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

        public User User
        {
            get { return user; }
            set
            {
                user = value;
                RaisePropertyChanged("User");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public CreateAccountWindowViewModel()
        {
            CreateUserCommand = new CreateUserCommand(this);
            user = new User();
            ShowLoginWindowView = new RelayCommand(ShowLoginWindowViewCommandExecute);
        }

        public void CreateUser()
        {
            using (CreedCollectorEntities ctx = new CreedCollectorEntities())
            {
                if (ctx.Users.Any(o => o.UserName == UserName))
                {
                    MessageBox.Show("User already exists"); // Needs converted to MVVM
                }
                else if (ctx.Users.Any(o => o.Email == Email))
                {
                    MessageBox.Show("Email already exists"); // Needs converted to MVVM
                }
                else
                {
                    ctx.Users.Add(new User
                    {
                        FirstName = FirstName,
                        LastName = LastName,
                        Email = Email,
                        UserName = UserName,
                        Password = PasswordHashing.CalculateHash(SecureStringManipulation.ConvertSecureStringToByteArray(PasswordSecureString)),
                        XboxLiveGamertag = XboxLiveGamertag,
                        PlaystationNetworkId = PsnName,
                        SteamId = SteamUsername
                    });

                    try
                    {
                        ctx.SaveChanges();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (var entityValidationErrors in ex.EntityValidationErrors)
                        {
                            foreach (var validationError in entityValidationErrors.ValidationErrors)
                            {
                                Debug.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                            }
                        }
                    }
                }
            }
        }

        public void ShowLoginWindowViewCommandExecute()
        {
            Messenger.Default.Send(new NotificationMessage("ShowLoginWindowView"));
        }

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
