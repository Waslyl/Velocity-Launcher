using DiscordRPC;
using System;

namespace Velocity_Launcher.Utilities
{
    internal class RPC
    {
        private static DiscordRpcClient client;

        public static void StartRPC()
        {
            try
            {
                Console.WriteLine("Starting RPC..");

                client = new DiscordRpcClient("1250090891587227750");
                client.Logger = new DiscordRPC.Logging.ConsoleLogger() { Level = DiscordRPC.Logging.LogLevel.Warning };

                client.OnReady += (sender, e) =>
                {
                    Console.WriteLine($"RPC Ready for User: {e.User.Username}");
                };

                client.OnPresenceUpdate += (sender, e) =>
                {
                    Console.WriteLine($"RPC Presence Update");
                };

                client.Initialize();
                UpdateRPC("In Launcher", true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("RPC Failed to Start: " + ex.Message);
            }
        }

        public static void UpdateRPC(string statenigge, bool includeTimestamp)
        {
            try
            {
                if (client == null || !client.IsInitialized)
                {
                    StartRPC();
                }

                // Create a new RichPresence object
                var presence = new RichPresence()
                {
                    Details = "Playing Rue",
                    State = $"{statenigge}",
                    Assets = new Assets()
                    {
                        LargeImageKey = "rue", // name of your logo in rich presence tab at discord.com/developers
                        LargeImageText = "ZarX on top",
                        SmallImageKey = "rue", // name of your logo in rich presence tab at discord.com/developers
                        SmallImageText = "Playing Rue"
                    },
                    Buttons = new Button[]
                    {
                new Button() { Label = "Join Rue Discord", Url = "discord invite link" }
                    }
                };
                if (includeTimestamp)
                {
                    presence.Timestamps = new Timestamps()
                    {
                        Start = DateTime.UtcNow
                    };
                }

                // Set the presence
                client.SetPresence(presence);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to update RPC presence: " + ex.Message);
            }
        }

        public static void StopRPC()
        {
            try
            {
                if (client != null)
                {
                    client.Dispose();
                    client = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to stop RPC: " + ex.Message);
            }
        }
    }
}
