using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheatreReportingApp.Models
{
    public class Authors
    {
        [Key]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(100, ErrorMessage = "Максимум 100 символов")]
        public string AuthorSurname { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(100, ErrorMessage = "Максимум 100 символов")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(100, ErrorMessage = "Максимум 100 символов")]
        public string AuthorFathername { get; set; }

        public int AuthorJobId { get; set; }
        [ForeignKey(nameof(AuthorJobId))]
        public AuthorJob AuthorJob { get; set; }

        public virtual ICollection<PlayAuthors> PlayAuthors { get; set; }
    }
}
