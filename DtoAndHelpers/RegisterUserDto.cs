using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TheatreReportingApp.DtoAndHelpers
{
    public class RegisterUserDto
    {
        [Required(ErrorMessage = "Email обязателен")]
        [EmailAddress(ErrorMessage = "Неверный формат email")]
        [Display(Name = "Почта")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Пароль обязателен")]
        [StringLength(100, ErrorMessage = "Пароль должен быть не менее {2} символов", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Подтверждение пароля обязательно")]
        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "Имя обязательно")]
        [Display(Name = "Имя")]
        [StringLength(100, ErrorMessage = "Имя должно быть не менее {2} символов", MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Фамилия обязательна")]
        [Display(Name = "Фамилия")]
        [StringLength(100, ErrorMessage = "Фамилия должна быть не менее {2} символов", MinimumLength = 2)]
        public string Surname { get; set; } = string.Empty;


        [DisplayName("Отчество")]
        [StringLength(100, ErrorMessage = "Отчество должно быть не менее {2} символов", MinimumLength = 3)]
        public string? Fathername { get; set; }

        [DisplayName("Роль")]
        [Required(ErrorMessage = "Роль обязательна")]
        public string? Rolename { get; set; }
    }
}
