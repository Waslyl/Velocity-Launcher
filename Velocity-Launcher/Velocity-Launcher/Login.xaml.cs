using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Velocity_Launcher.Properties;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;

namespace Velocity_Launcher
{
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailBox.Text;
            string password = PasswordBox.Password;

            Settings.Default["Email"] = email;
            Settings.Default["Password"] = password;
            Settings.Default.Save();

            var mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();

        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/zHvv9Pb6ax");
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
    }
}