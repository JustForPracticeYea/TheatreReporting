using System.ComponentModel.DataAnnotations;

namespace TheatreReportingApp.Models
{
    public class Play
    {
        [Key]
        public int PlayId { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(100, ErrorMessage = "Максимум 100 символов")]
        public string Title { get; set; }

        public virtual ICollection<PlayAuthors> PlayAuthors { get; set; }
    }
}
