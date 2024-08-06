using CreedCollector.AttachedProperties;
using CreedCollector.ViewModels.Interfaces;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CreedCollector
{
    /// <summary>
    /// Interaction logic for LoginWindowView.xaml
    /// </summary>
    public partial class LoginWindowView : Window
    {
        public LoginWindowView()
        {
            InitializeComponent();
            Messenger.Default.Register<NotificationMessage>(this, NotificationMessageReceived);
        }

        /* This method recieves the message from the LoginWindowViewModel and then creates a new 
         * UserDashboardWindowView, closes the Login Window, and shows the User Dashboard. */
        private void NotificationMessageReceived(NotificationMessage msg)
        {
            if (msg.Notification == "ShowUserDashboardWindowView")
            {
                UserDashboardWindowView view = new UserDashboardWindowView();
                var window = Window.GetWindow(this);
                window.Close();
                view.Show();
            }
            else if (msg.Notification == "ShowCreateAccountWindowView")
            {
                CreateAccountWindowView createAccountWindowView = new CreateAccountWindowView();
                var window = Window.GetWindow(this);
                window.Close();
                createAccountWindowView.Show();
            }
        }

        /* This method is for sending the text in the password box so that it can be encrypted */
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox pBox = sender as PasswordBox;

            PasswordBoxAttachedProperties.SetEncryptedPassword(pBox, pBox.SecurePassword);
        }
    }
}
