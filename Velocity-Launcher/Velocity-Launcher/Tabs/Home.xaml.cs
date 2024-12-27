using System;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using Velocity_Launcher.Resources.Launch;

namespace Velocity_Launcher.Tabs
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        Thread launcherThread;
        bool running = false;
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }
        public Home()
        {
            InitializeComponent();
        }
        public void Launch()
        {
            Game game = new Game();
            game.InitializeFortnite();
        }
        private void Discord_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/zHvv9Pb6ax");
        }
        private void Launch_Click(object sender, RoutedEventArgs e)
        {
            launcherThread = new Thread(Launch);
            launcherThread.Start();
        }
    }
}
