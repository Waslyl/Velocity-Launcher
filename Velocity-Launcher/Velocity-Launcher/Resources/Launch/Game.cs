using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Velocity_Launcher.Properties;
using Velocity_Launcher.Services;
using WindowsAPICodePack.Dialogs;

namespace Velocity_Launcher.Resources.Launch
{
	internal class Game
	{
        private Process Fortnitegame;
        private bool isMonitoring = false;
        private Thread monitorThread;

        public void StartMonitoring()
        {
            if (!isMonitoring)
            {
                isMonitoring = true;
                monitorThread = new Thread(() =>
                {
                    while (isMonitoring)
                    {
                        try
                        {
                            if (Fortnitegame != null && !Fortnitegame.HasExited)
                            {
                                string outputLine;
                                while ((outputLine = Fortnitegame.StandardOutput.ReadLine()) != null)
                                {
                                    if (outputLine.Contains("Region ")) //Connection to server
                                    {
                                        MessageBox.Show("TestEditOnRelease");
                                        /*Thread.Sleep(5000);
                                        Injection.InjectDll(Fortnitegame.Id, Path.Combine(Settings.Default.Path, "Engine\\Binaries\\ThirdParty\\NVIDIA\\NVaftermath\\Win64\\memory.dll")); // Edit On Release */
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Error in monitoring thread: {ex.Message}");
                        }
                        Thread.Sleep(1000); // Prevent excessive CPU usage
                    }
                });
                monitorThread.IsBackground = true;
                monitorThread.Start();
            }
        }

        public void StopMonitoring()
        {
            isMonitoring = false;
            if (monitorThread != null && monitorThread.IsAlive)
            {
                monitorThread.Join(1000); // Wait for thread to finish
            }
        }

        
        public void SelectFortnitePath()
        {
            using (CommonOpenFileDialog dialog = new CommonOpenFileDialog())
            {
                dialog.Multiselect = false;
                dialog.Title = "Select Fortnite 12.41 Build.";
                dialog.IsFolderPicker = true;
                dialog.EnsurePathExists = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    if (!Directory.Exists(dialog.FileName + "\\FortniteGame"))
                    {
                        System.Windows.MessageBox.Show("Error: The path is incorrect.\nPlease check if your season is correctly installed !");
                        return;

                    }
                    else
                    {
                        MessageBox.Show("Season 12.41 as been saved correctly !");
                        Settings.Default.Path = dialog.FileName;
                        Settings.Default.Save();
                    }
                }
            }
        }
		public void InitializeFortnite()
		{
            string gamePath = Settings.Default.Path;

            if (string.IsNullOrEmpty(gamePath) || string.IsNullOrEmpty(Settings.Default.Email) || string.IsNullOrEmpty(Settings.Default.Password))
            {
                MessageBox.Show("Veuillez bien mettre votre email/MDP ou Chemin");
                return;
            }

            Thread LaunchProcessThread = new Thread(() =>
            {
                SuspendFortniteProcess(gamePath, "FortniteGame/Binaries/Win64/FortniteLauncher.exe", true);
                SuspendFortniteProcess(gamePath, "FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping_EAC.exe", true);
            });

            Thread gameThread = new Thread(() =>
            {
                StartFortnite(gamePath);
            });
            gameThread.Start();
        }

        private void SuspendFortniteProcess(string gamePath, string relativePath, bool suspend)
        {
            Process process = new Process();
            process.StartInfo.FileName = Path.Combine(gamePath, relativePath);
            process.Start();
            if (suspend)
            {
                SuspendProcess.Suspend(process);
            }
        }

        private Process StartFortnite(string gamePath)
        {
            try
            {
                Process Fortnitegame = new Process();
                Fortnitegame.StartInfo.FileName = Path.Combine(Settings.Default.Path, "FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping.exe");
                Fortnitegame.StartInfo.RedirectStandardOutput = false;
                Fortnitegame.StartInfo.Verb = "runas";
                Fortnitegame.StartInfo.Arguments = $@"-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -skippatchcheck -nobe -fromfl=eac -fltoken=3db3ba5dcbd2e16703f3978d -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiYmU5ZGE1YzJmYmVhNDQwN2IyZjQwZWJhYWQ4NTlhZDQiLCJnZW5lcmF0ZWQiOjE2Mzg3MTcyNzgsImNhbGRlcmFHdWlkIjoiMzgxMGI4NjMtMmE2NS00NDU3LTliNTgtNGRhYjNiNDgyYTg2IiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.VAWQB67RTxhiWOxx7DBjnzDnXyyEnX7OljJm-j2d88G_WgwQ9wrE6lwMEHZHjBd1ISJdUO1UVUqkfLdU5nofBQ -AUTH_LOGIN={Settings.Default["Email"]} -AUTH_PASSWORD={Settings.Default["Password"]} -AUTH_TYPE=epic";
                Fortnitegame.Start(); // Launch Fortnite

                return Fortnitegame;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
