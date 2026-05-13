using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TheatreReportingApp.Models
{
    public class Users : IdentityUser
    {
        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(100, ErrorMessage = "Максимум 100 символов")]
        [DisplayName ("Фамилия")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(100, ErrorMessage = "Максимум 100 символов")]
        [DisplayName("Имя")]
        public string Name { get; set; }

        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(100, ErrorMessage = "Максимум 100 символов")]
        [DisplayName("Отчество")]
        public string? Fathername { get; set; }

        public bool? IsDelete { get; set; }
    }
}
