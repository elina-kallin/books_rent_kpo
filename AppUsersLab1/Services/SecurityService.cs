using AppUsersLab1.Models;
using System.Security.Cryptography;
using System.Text;
using DES = AppUsersLab1.Services.Encription.DES;

namespace AppUsersLab1.Services
{
    public static class SecurityService
    {
        static string numbers = "0123456789";
        static string ru_letters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        static string en_letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string punkt_marks = ".,!?;:";
        public static string ComputeHash(string password)
        {
            byte[] passwordBites = Encoding.UTF8.GetBytes(password);
            byte[] hashedBytes = MD5.HashData(passwordBites);
            return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
        }

        public static byte[] Encrypt(string data)
        {
            return DES.Encrypt(data);
        }

        public static string Decrypt(byte[] bytes)
        {
            return DES.Decrypt(bytes);
        }

        public static bool SetPassword(User user, string password, bool checkValide = false)
        {
            bool hasRULetters = password.Any(l => ru_letters.Contains(l));
            bool hasENLetters = password.Any(l => en_letters.Contains(l));
            bool hasNumbers = password.Any(l => numbers.Contains(l));
            bool hasPunktMarks = password.Any(l => punkt_marks.Contains(l));
            if(checkValide == true)
            {
                if (user.IsChangedPassword & string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Введите пароль!");
                    return false;
                }
                if (user.LettersRequire & !(hasRULetters || hasENLetters))
                {
                    MessageBox.Show("Пароль должен содержать хотя бы одну букву!");
                    return false;
                }
                if (user.NumbersRequire & !hasNumbers)
                {
                    MessageBox.Show("Пароль должен содержать хотя бы одну цифру!");
                    return false;
                }
                if (user.PunktMarksRequire & !hasPunktMarks)
                {
                    MessageBox.Show($"Пароль должен содержать хотя бы один знак из следующих: {punkt_marks}");
                    return false;
                }

                if (password.Length < user.MinPasswordLength)
                {
                    MessageBox.Show($"Длина пароля не может быть меньше {user.MinPasswordLength} символов");
                    return false;
                }
            }
            

            user.HashedPassword = ComputeHash(password);
            user.DateSetPassword = DateTime.Now;
            return true;
        }

        public static bool CheckHashPassword(User user, string password)
        {
            bool isUnique = user.HashedPassword.Equals(ComputeHash(password));
            return isUnique;
        }
    }
}
