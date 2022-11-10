using System;
using System.IO;
using Crying.Reader;
using Crying.Helpers;
using static Crying.Helpers.Common;


namespace rshell
{
    class lepakko
    {
        static void LepakkoMies(string[] args)
        {
            // Get command line args
            string arguments = string.Join(" ", args).ToLower();
            if (string.IsNullOrEmpty(arguments))
            {
                Console.WriteLine("passwords/cookies/history/bookmarks");
                Environment.Exit(1);
            }

            foreach (string browser in Profile.GetMozillaBrowsers())
            {
                // Show info
                Console.WriteLine("Reading " + arguments + " from " + new DirectoryInfo(browser).Name + " browser.");

                // :::::::DDDDDDD VITTU KEKSI t: Viljami
                // Get cookies

                // Get history
                if (arguments.Equals("history"))
                {
                    foreach (Site history in History.Get(browser))
                    {
                        Console.WriteLine(BrowserUtils.FormatHistory(history));
                    }
                }
            }
            Console.WriteLine("DONE");
        }
    }
}