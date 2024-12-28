using System;
using System.Windows;
using System.Windows.Controls;
using System.Diagnostics;
using Velocity_Launcher.Properties;
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
            bool currentState = EditOnReleaseToggle.Tag?.ToString() == "True";

            Game game = new Game();
            game.ToggleEditOnRelease(currentState);

            EditOnReleaseToggle.Tag = currentState ? "False" : "True";

            e.Handled = true;
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Window parentWindow = Window.GetWindow(this);

            if (parentWindow != null)
            {
                MainWindow mainWindow = parentWindow as MainWindow;

                Login loginWindow = new Login();

                loginWindow.Show();

                mainWindow.Close();
            }
        }
    }
}
