using ModernWpf.Controls;
using ModernWpf;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Velocity_Launcher.Tabs;
using ModernWpf.Media.Animation;
using System;
using System.Net;
using Windows.Media.Protection.PlayReady;
using DiscordRPC;

namespace Velocity_Launcher
{
	public partial class MainWindow : Window
	{

		// Refrence Pages
		
		Home home = new Home();
		Settings settings = new Settings();
        Downloads download = new Downloads();
        private DiscordRpcClient client;
        public MainWindow()
		{
			InitializeComponent();

        }

		private void NavView_Loaded(object sender, RoutedEventArgs e)
		{
			ContentFrame.Navigate(home);
		}

		private void NavView_SelectionChanged(ModernWpf.Controls.NavigationView sender, ModernWpf.Controls.NavigationViewSelectionChangedEventArgs args)
		{
			if (args.IsSettingsSelected)
			{
				ContentFrame.Navigate(settings);
			}else
			{
				NavigationViewItem item = args.SelectedItem as NavigationViewItem;

				if (item.Tag.ToString() == "Home")
				{
					ContentFrame.Navigate(home);
					
				}

				if (item.Tag.ToString() == "Downloads")
				{
					ContentFrame.Navigate(download);
				}
            }
		}

		private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
		{
			throw new Exception("The page couldn't load.");
		}
    }
}
