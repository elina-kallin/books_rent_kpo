using System.Security.Cryptography;
using System.Text;

namespace AppUsersLab1.Services.Encription
{
    public static class DES
    {
        private static readonly byte[] KEY = Encoding.ASCII.GetBytes("key_encr");
        private static readonly byte[] IV = Encoding.ASCII.GetBytes("init_vec");

        public static byte[] Encrypt(string data)
        {
            return EncryptOFB(Encoding.UTF8.GetBytes(data), KEY, IV);
        }

        public static string Decrypt(byte[] encrypted)
        {
            return Encoding.UTF8.GetString(DecryptOFB(encrypted, KEY, IV));
        }

        // Реализация режима OFB вручную
        static byte[] EncryptOFB(byte[] plainText, byte[] key, byte[] iv)
        {
            using (var des = System.Security.Cryptography.DES.Create())
            {
                des.Key = key;
                des.Mode = CipherMode.ECB; // Используем ECB как базовый блок
                des.Padding = PaddingMode.None;

                var encryptor = des.CreateEncryptor();
                var blockSize = des.BlockSize / 8; // Размер блока в байтах

                // В OFB режиме мы шифруем IV, затем используем результат как следующий вход
                var output = new byte[plainText.Length];
                var feedback = new byte[blockSize];
                Array.Copy(iv, feedback, blockSize);

                for (int i = 0; i < plainText.Length; i += blockSize)
                {
                    // Шифруем текущий feedback
                    var encryptedFeedback = encryptor.TransformFinalBlock(feedback, 0, blockSize);

                    // XOR с открытым текстом
                    var blockLength = Math.Min(blockSize, plainText.Length - i);
                    for (int j = 0; j < blockLength; j++)
                    {
                        output[i + j] = (byte)(plainText[i + j] ^ encryptedFeedback[j]);
                    }

                    // Обновляем feedback для следующего блока
                    Array.Copy(encryptedFeedback, feedback, blockSize);
                }

                return output;
            }
        }

        static byte[] DecryptOFB(byte[] cipherText, byte[] key, byte[] iv)
        {
            // В OFB режиме дешифрование идентично шифрованию
            return EncryptOFB(cipherText, key, iv);
        }

        // Альтернативная реализация с использованием потокового подхода
        public static byte[] EncryptOFBStream(byte[] plainText, byte[] key, byte[] iv)
        {
            using (var des = System.Security.Cryptography.DES.Create())
            {
                des.Key = key;
                des.Mode = CipherMode.ECB;
                des.Padding = PaddingMode.None;

                var blockSize = des.BlockSize / 8;
                var output = new byte[plainText.Length];
                var currentVector = new byte[blockSize];
                Array.Copy(iv, currentVector, blockSize);

                using (var encryptor = des.CreateEncryptor())
                {
                    for (int i = 0; i < plainText.Length; i += blockSize)
                    {
                        // Шифруем текущий вектор
                        var keystream = encryptor.TransformFinalBlock(currentVector, 0, blockSize);

                        // Применяем XOR к данным
                        var blockLength = Math.Min(blockSize, plainText.Length - i);
                        for (int j = 0; j < blockLength; j++)
                        {
                            output[i + j] = (byte)(plainText[i + j] ^ keystream[j]);
                        }

                        // Обновляем вектор для следующего блока
                        Array.Copy(keystream, currentVector, blockSize);
                    }
                }

                return output;
            }
        }
    }
}