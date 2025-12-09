using BooksRent.Models.enums;
using System.ComponentModel;

namespace BooksRent.Models
{
    public class RentCheck
    {
        [Browsable(false)]
        [DisplayName("Id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Browsable(false)]
        [DisplayName("BookId")]
        public string BookId { get; set; } = Guid.NewGuid().ToString();

        [Browsable(false)]
        [DisplayName("Userd")]
        public string UserId { get; set; } = Guid.NewGuid().ToString();

        [DisplayName("ФИО")]
        public string FIO { get; set; } = string.Empty;


        [DisplayName("Статус аренды")]
        public StatusRent StatusRent { get; set; } = StatusRent.Свободна;


    }
}
