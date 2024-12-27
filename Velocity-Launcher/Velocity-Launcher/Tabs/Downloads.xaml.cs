using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Velocity_Launcher.Resources;
using Windows.Storage;
using Velocity_Launcher.Properties;
using WindowsAPICodePack.Dialogs;
using Velocity_Launcher.Resources.Launch;

namespace Velocity_Launcher.Tabs
{
    /// <summary>
    /// Interaction logic for Downloads.xaml
    /// </summary>
    public partial class Downloads : Page
    {
        public Downloads()
        {
            InitializeComponent();
        }

        private void TwelveFortyOne_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://cdn.fnbuilds.services/Fortnite%2012.41.zip");
        }

        private void TwelveFortyOne_Path(object sender, RoutedEventArgs e)
        {
            Game game = new Game();
            game.SelectFortnitePath();
        }
    }
}
