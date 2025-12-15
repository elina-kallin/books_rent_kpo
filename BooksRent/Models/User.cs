using AppUsersLab1.Enums;
using System.ComponentModel;

namespace AppUsersLab1.Models
{
    public class User
    {
        [Browsable(false)]
        [DisplayName("Id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public bool IsChangedPassword { get; set; } = false;

        [DisplayName("Имя пользователя")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Username")]
        public string UserName { get; set; } = string.Empty;

        [Browsable(false)]
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// захешированный пароль
        /// </summary>
        [Browsable(false)]
        public string HashedPassword { get; set; } = string.Empty;

        [DisplayName("Роль")]
        public UserRoles Roles { get; set; } = UserRoles.Пользователь;

        /// <summary>
        /// минимальная длина пароля
        /// </summary>
        [DisplayName("Минимальная длина пароля")]
        public int MinPasswordLength { get; set; } = 0;

        /// <summary>
        /// срок действия пароля в месяцах
        /// </summary>
        [DisplayName("Срок действия пароля")]
        public int PeriodLifePassword {  get; set; } = 0;

        /// <summary>
        /// флаг - нужны ли буквы в пароле
        /// </summary>
        [DisplayName("Буквы")]
        public bool LettersRequire { get; set; } = false;

        /// <summary>
        /// флаг - нужны ли цифры в пароле
        /// </summary>
        [DisplayName("Цифры")]
        public bool NumbersRequire { get; set; } = false;

        /// <summary>
        /// флаг - нужны ли знаки препинания в пароле
        /// </summary>
        [DisplayName("Знаки препинания")]
        public bool PunktMarksRequire { get; set; } = false;

        /// <summary>
        /// дата установки пароля
        /// </summary>
        [DisplayName("Дата установки пароля")]
        public DateTime DateSetPassword { get; set; } = DateTime.Now;

        /// <summary>
        /// флаг - заблокирован ли пользователь
        /// </summary>
        [DisplayName("Блокировка")]
        public bool IsBlocked { get; set; } = false;

    }
}
