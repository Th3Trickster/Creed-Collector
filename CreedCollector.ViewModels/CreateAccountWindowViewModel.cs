using CreedCollector.Models;
using CreedCollector.ViewModels.Commands;
using CreedCollector.ViewModels.Hashing;
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

        public CreateUserCommand CreateUserCommand { get; set; }

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
                        Password = PasswordHashing.CalculateHash(SecureStringManipulation.ConvertSecureStringToByteArray(PasswordSecureString))
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
