using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheatreReportingApp.Models
{
    public class Report
    {
        [Key]
        public int ReportId { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        [MinLength(3, ErrorMessage = "Минимум 3 символа")]
        [MaxLength(150, ErrorMessage = "Максимум 150 символов")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Данное поле обязательно для заполнения")]
        public string Content { get; set; }

        public string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public Users User { get; set; }

        public List<Performance>? Performances { get; set; }
    }
}
