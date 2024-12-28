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

        public void ToggleEditOnRelease(bool currentState)
        {
            // Basculer l'état
            bool newState = !currentState;
            Settings.Default.EditOnRelease = newState;
            Settings.Default.Save();

            // Notification utilisateur
            MessageBox.Show($"Edit On Release is now {(newState ? "Enabled" : "Disabled")}");
        }

        public void InitializeFortnite()
        {
            string gamePath = Settings.Default.Path;

            if (string.IsNullOrEmpty(gamePath) || string.IsNullOrEmpty(Settings.Default.Email) || string.IsNullOrEmpty(Settings.Default.Password))
            {
                MessageBox.Show("Veuillez bien mettre votre email, mot de passe, et chemin du jeu !");
                return;
            }

            bool editOnRelease = Settings.Default.EditOnRelease;

            Thread launchThread = new Thread(() =>
            {
                SuspendFortniteProcess(gamePath, "FortniteGame/Binaries/Win64/FortniteLauncher.exe", true);
                SuspendFortniteProcess(gamePath, "FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping_EAC.exe", true);
                StartFortnite(gamePath, editOnRelease);
            });

            launchThread.Start();
        }

        private void SuspendFortniteProcess(string gamePath, string relativePath, bool suspend)
        {
            try
            {
                Process process = new Process
                {
                    StartInfo =
                    {
                        FileName = Path.Combine(gamePath, relativePath),
                        UseShellExecute = true
                    }
                };
                process.Start();

                if (suspend)
                {
                    SuspendProcess.Suspend(process);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suspension du processus : {ex.Message}");
            }
        }

        private Process StartFortnite(string gamePath, bool editOnRelease)
        {
            string launcherPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string dllPath = Path.Combine(launcherPath, "console.dll");

            try
            {
                if (!File.Exists(dllPath))
                {
                    MessageBox.Show($"DLL not found.\nPlease re download the launcher !");
                }

                Process Fortnitegame = new Process();
                Fortnitegame.StartInfo.FileName = Path.Combine(Settings.Default.Path, "FortniteGame/Binaries/Win64/FortniteClient-Win64-Shipping.exe");
                Fortnitegame.StartInfo.RedirectStandardOutput = true;
                Fortnitegame.StartInfo.UseShellExecute = false;
                Fortnitegame.StartInfo.Verb = "runas";
                Fortnitegame.StartInfo.Arguments = $@"-epicapp=Fortnite -epicenv=Prod -epiclocale=en-us -epicportal -skippatchcheck -nobe -fromfl=eac -fltoken=3db3ba5dcbd2e16703f3978d -caldera=eyJhbGciOiJFUzI1NiIsInR5cCI6IkpXVCJ9.eyJhY2NvdW50X2lkIjoiYmU5ZGE1YzJmYmVhNDQwN2IyZjQwZWJhYWQ4NTlhZDQiLCJnZW5lcmF0ZWQiOjE2Mzg3MTcyNzgsImNhbGRlcmFHdWlkIjoiMzgxMGI4NjMtMmE2NS00NDU3LTliNTgtNGRhYjNiNDgyYTg2IiwiYWNQcm92aWRlciI6IkVhc3lBbnRpQ2hlYXQiLCJub3RlcyI6IiIsImZhbGxiYWNrIjpmYWxzZX0.VAWQB67RTxhiWOxx7DBjnzDnXyyEnX7OljJm-j2d88G_WgwQ9wrE6lwMEHZHjBd1ISJdUO1UVUqkfLdU5nofBQ -AUTH_LOGIN={Settings.Default["Email"]} -AUTH_PASSWORD={Settings.Default["Password"]} -AUTH_TYPE=epic";
                Fortnitegame.Start(); // Launch Fortnite

                /*if (editOnRelease)
                {
                    string outputLine;
                    while ((outputLine = Fortnitegame.StandardOutput.ReadLine()) != null)
                    {
                        if (editOnRelease && outputLine.Contains("Region "))
                        {
                            Thread.Sleep(5000);
                            Injection.InjectDll(Fortnitegame.Id, dllPath);
                            MessageBox.Show("Dll successfully injected,\nclick F3 when ingame !");
                            break;
                        }
                    }
                    
                }*/

                return Fortnitegame;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting Fortnite: {ex.Message}");
                return null;
            }
        }
    }
}
