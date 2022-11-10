using System;
using System.IO;
using System.Security.Cryptography;

namespace rshell
{
    internal static class Decryptor
    {
        private static Aes aes;
        private static int read;
        private static byte[] buffer = new byte[Settings.bufferSize];

        public static void Decrypt()
        {
            using (aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.Zeros;
                aes.KeySize = 128;
                aes.IV = Settings.iv;
                aes.Key = Settings.key;

                // Decrypt files
                Utils.EnumerateFiles(DecryptFile);
            }
        }

       private static void DecryptFile(string path)
        {
            if (!path.EndsWith(Settings.extension)) 
                return;

            try
            {
                using (var encrypted = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    using (var original = File.Open(Utils.RemoveExtension(path), FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        using (var transform = aes.CreateDecryptor())
                        {
                            using (var crypto = new CryptoStream(encrypted, transform, CryptoStreamMode.Read))
                            {
                                while ((read = crypto.Read(buffer, 0, buffer.Length)) != 0)
                                {
                                    original.Write(buffer, 0, read);
                                }
                            }
                        }
                    }
                }
                File.Delete(path);
            }
            catch (Exception)
            {

            }
        }
    }
}
