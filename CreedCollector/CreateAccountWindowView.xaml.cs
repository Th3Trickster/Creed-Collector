using CreedCollector.AttachedProperties;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for CreateAccountWindowView.xaml
    /// </summary>
    public partial class CreateAccountWindowView : Window
    {
        public CreateAccountWindowView()
        {
            InitializeComponent();
            Messenger.Default.Register<NotificationMessage>(this, NotificationMessageReceived);
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            PasswordBox pBox = sender as PasswordBox;

            PasswordBoxAttachedProperties.SetEncryptedPassword(pBox, pBox.SecurePassword);
        }

        private void NotificationMessageReceived(NotificationMessage msg)
        {
            if (msg.Notification == "ShowLoginWindowView")
            {
                LoginWindowView loginWindowView = new LoginWindowView();
                var window = Window.GetWindow(this);
                window.Close();
                loginWindowView.Show();
            }
        }
    }
}
