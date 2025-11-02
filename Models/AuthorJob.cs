using System.ComponentModel.DataAnnotations;
namespace TheaterReporting.Models
{
    public class AuthorJob
    {
        [Key]
        public int AuthorJobId {  get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(100, ErrorMessage = "Максимум 100 символов")]
        public string Title { get; set; }
    }
}
