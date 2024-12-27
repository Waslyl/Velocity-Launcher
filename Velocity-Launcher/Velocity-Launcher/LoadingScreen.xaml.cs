using System;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using Velocity_Launcher.Resources;
using Velocity_Launcher.Properties;
using System.IO;
using System.Reflection;
using System.Text;

namespace Velocity_Launcher
{
    public partial class LoadingScreen : Window
    {
        public LoadingScreen()
        {
            InitializeComponent();
            StartLoadingProcess();
        }

        private async void StartLoadingProcess()
        {
            await Task.Delay(1000);
            Dispatcher.Invoke(() => LoadingTextBox.Text = "Checking For Updates!");
            WebClient omg = new WebClient();

            await Task.Delay(1000);
            Dispatcher.Invoke(() => LoadingTextBox.Text = "Logging in!");



            if (Settings.Default.Email == "" || Settings.Default.Password == "") // Show login only if credentials are wrong
            {
                var login = new Login();
                login.Show();
                this.Close(); // Close the loading screen if credentials are wrong
            }
            else
            {
                var mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close(); // Close the loading screen if credentials are correct
            }
        }

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
    }
}