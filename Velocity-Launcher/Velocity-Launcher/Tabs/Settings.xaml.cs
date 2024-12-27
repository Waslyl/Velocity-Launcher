using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Velocity_Launcher.Services;
using Velocity_Launcher.Resources.Launch;

namespace Velocity_Launcher.Tabs
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Settings : Page
    {


        public Settings()
        {
            InitializeComponent();
        }

        private void EditOnRelease_Toggle(object sender, RoutedEventArgs e)
        {
            EditOnReleaseToggle.Tag = (EditOnReleaseToggle.Tag?.ToString() == "True") ? "False" : "True";

            if (EditOnReleaseToggle.Tag?.ToString() == "True")
            {
                Game game = new Game();
                game.StartMonitoring();
            }
            else
            {
                Game game = new Game();
                game.StopMonitoring();
            }

            e.Handled = true;
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            // Assuming MainWindow is the parent window
            Window parentWindow = Window.GetWindow(this);

            if (parentWindow != null)
            {
                MainWindow mainWindow = parentWindow as MainWindow;

                // Create a new instance of the login window
                Login loginWindow = new Login();

                // Show the login window
                loginWindow.Show();

                // Close the current (main) window
                mainWindow.Close();
            }
        }
    }
}
