using System.ComponentModel;

namespace TheatreReportingApp.ViewModels
{
    public class UserDto
    {
        public string Id { get; set; }

        [DisplayName("Номер записи")]
        public int RowNumber { get; set; }

        [DisplayName("Фамилия")]
        public string? Surname { get; set; }

        [DisplayName("Имя")]
        public string? Name { get; set; }

        [DisplayName("Отчество")]
        public string? Fathername { get; set; }

        [DisplayName("Роль")]
        public string? Rolename { get; set; }

        [DisplayName("Почта")]
        public string? Email { get; set; }
    }
}
