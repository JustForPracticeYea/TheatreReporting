using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TheatreReportingApp.DtoAndHelpers
{
    public class AuthorsDto
    {

        [DisplayName("Фамилия")]
        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(100, ErrorMessage = "Максимум 100 символов")]
        public string AuthorSurname { get; set; } = string.Empty;

        [DisplayName("Имя")]
        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(100, ErrorMessage = "Максимум 100 символов")]
        public string AuthorName { get; set; } = string.Empty;

        [DisplayName("Отчество")]
        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(100, ErrorMessage = "Максимум 100 символов")]
        public string? AuthorFathername { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [Range(1, int.MaxValue, ErrorMessage = "Пожалуйста, выберите работу автора")]
        public int? SelectedJobId { get; set; }
    }
}
