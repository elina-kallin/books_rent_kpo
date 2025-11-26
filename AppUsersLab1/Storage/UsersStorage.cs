using AppUsersLab1.Models;
using AppUsersLab1.Services;
using System.Text.Json;

namespace AppUsersLab1.Storage
{
    public class UsersStorage
    {
        private static UsersStorage? _instance;
        private List<User>? _users;
        private readonly string fileUsersPath = "D:\\code\\information_security\\InformationSecurity\\AppUsersLab1\\Storage\\data.enc";

        private UsersStorage()
        {
            _users = LoadUsersFromFile();
            if (_users.Count == 0)
            {
                _users = InitUsers();
            }
        }

        public static UsersStorage GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UsersStorage();
            }
            return _instance;
        }

        private List<User> InitUsers()
        {
            _users = new List<User>();
            var admin = new User();
            admin.Roles = Enums.UserRoles.Администратор;
            admin.Name = "Начальный Админ";
            admin.UserName = "admin";
            admin.IsChangedPassword = true;
            SecurityService.SetPassword(admin, "", false);
            _users.Add(admin);
            return _users;
        }

        private List<User>? LoadUsersFromFile()
        {
            if (File.Exists(fileUsersPath))
            {
                try
                {
                    byte[] bytes = File.ReadAllBytes(fileUsersPath);
                    string decryptData = SecurityService.Decrypt(bytes);
                    return JsonSerializer.Deserialize<List<User>>(decryptData);
                }
                catch (Exception)
                {
                    var users = InitUsers();
                    SaveInFile();
                    return users;
                }
            }
            else
            {
                MessageBox.Show("Файл с учетными записями был перемещен, либо утерян. \nБудет создан пустой файл \nс начальным администратором системы");
                var users = InitUsers();
                SaveInFile();
                return users;
            }
        }

        private void SaveInFile()
        {
            string jsonString = JsonSerializer.Serialize(_users);
            byte[] bytes = SecurityService.Encrypt(jsonString);
            File.WriteAllBytes(fileUsersPath, bytes);
        }

        public List<User>? GetUsers()
        {
            return _users;
        }

        public User? GetById(string id)
        {
            return _users?.First(x => x.Id == id);
        }

        public User? GetByUsername(string username)
        {
            return _users?.FirstOrDefault(x => x.UserName == username);
        }

        public User Add(User user)
        {
            if (UniqueUsername(user.UserName))
            {
                SecurityService.SetPassword(user, user.Password, false);
                _users.Add(user);
                SaveInFile();
                return user;
            }
            MessageBox.Show("Имя пользователя не уникально!");
            return null;
        }

        public User Delete(User user)
        {
            _users.Remove(user);
            SaveInFile();
            return user;
        }

        public User Update(User user)
        {
            if (UniqueUsername(user.UserName, user.Id)) 
            {
                int id = _users.FindIndex(x => x.Id == user.Id);
                if (id == -1)
                {
                    throw new InvalidOperationException("Пользователь не найден");
                }
                SecurityService.SetPassword(user, user.Password, true);
                _users[id] = user;
                SaveInFile();
                return user;
            }
            else
            {
                MessageBox.Show("Имя пользователя не уникально!");
                return null;
            }
        }

        public bool UniqueUsername(string username, string excludeUserId = null)
        {
            if (_users == null) return true;

            return !_users.Any(x =>
                x.UserName?.ToLower() == username?.ToLower() &&
                (excludeUserId == null || x.Id != excludeUserId) // Исключаем текущего пользователя
            );
        }
    }
}
