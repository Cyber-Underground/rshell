#if DEBUG
using System;
using System.IO;

namespace rshell
{
    internal class Logger : IDisposable
    {
        private string path;
        private StreamWriter writer;

        public Logger(string path)
        {
            this.path = path;
        }

        public void WriteLine(string message)
        {
            if (writer == null)
            {
                var stream = File.Open(path, FileMode.Create, FileAccess.Write, FileShare.Read);
                writer = new StreamWriter(stream);
            }

            var now = DateTime.Now;
            writer.WriteLine($"[{now.ToShortDateString()} {now.ToShortTimeString()}]  {message}");
            writer.Flush();
        }

        public void Dispose()
        {
            if (writer != null) writer.Close();
        }

        public static Logger Log = new Logger(Path.Combine(Utils.GetParentDirectory(), Settings.logfile));
    }
}
#endif